using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System.Collections.Generic;
using Eindopdracht_DesignPatterns.controllers;

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


        public override bool Accept(ValidNodeVisitor validNodeVisitor)
        {
            return true;
        }

        public override void CalculateOutput(int value)
        {
        }

        public override void ClearCircuit()
        {
            foreach (var node in AllNodes) node.Value.Clear();
        }
    }
}
