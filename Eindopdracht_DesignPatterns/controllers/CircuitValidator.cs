using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.State_pattern;
using QuickGraph;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitValidator : IValidator
    {
        private Circuit Circuit { get; set; }

        public CircuitValidator(Circuit circuit)
        {
            Circuit = circuit;
        }

        public IState CheckState()
        {
            if (UnreachableNodes()) return new UnreachableProbes();
            if (Loop()) return new Loop();
            return new ValidCircuit();
        }

        public bool Loop()
        {

            foreach (var node in Circuit.AllNodes)
            {
                if (node.Value is Composite)
                {
                    var composite = (Composite) node.Value; 
                    if (composite.Loop()) return true;
                }
            }
            return false;
        }

        private bool UnreachableNodes()
        {
            return Circuit.AllNodes.Any(circuit => !circuit.Value.ValidNode());
        }
    }
}
