using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System.Linq;
using Eindopdracht_DesignPatterns.controllers.State_pattern;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitValidator : IValidator
    {
        private Circuit Circuit { get; set; }
        public IState CurrentState { get; set; }

        public CircuitValidator(Circuit circuit)
        {
            Circuit = circuit;
        }

        public void SetState()
        {
            Circuit.State = new ValidCircuit();
            UnreachableNodes();
            Loop();
        }

        public void Loop()
        {
            foreach (var node in Circuit.AllNodes)
            {
                if (node.Value is Composite)
                {
                    var composite = (Composite) node.Value;
                    if (composite.Loop())
                    {
                        Circuit.State = new Loop();
                    }
                }
            }
        }

        private void UnreachableNodes()
        {
            ValidNodeVisitor validNodeVisitor = new ValidNodeVisitor();

            if (Circuit.AllNodes.Any(circuit => !circuit.Value.Accept(validNodeVisitor)))
            {
                Circuit.State = new UnreachableProbes(); 
            }
        }

    }
}
