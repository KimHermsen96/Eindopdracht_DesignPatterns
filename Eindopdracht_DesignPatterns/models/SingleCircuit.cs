using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public class SingleCircuit : Circuit
    {
        public override Dictionary<string, Node> AllNodes { get; set; }
        public override List<Node> Firsts { get; set; }
        public override IState State { get; set; }
        public override string Name { get; set; }

        public SingleCircuit()
        {
            AllNodes = new Dictionary<string, Node>();
            Firsts = new List<Node>();
            State = null;
        }

        public void Run()
        {
            State.DoAction(this);
        }

        public override void CalculateOutput(int value)
        {
        }

        public override bool ValidNode()
        {
            return true;
        }

        public override void ClearCircuit()
        {
            foreach (var node in AllNodes) node.Value.Clear();
        }
    }
}
