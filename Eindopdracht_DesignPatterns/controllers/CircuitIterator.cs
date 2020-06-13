using System;
using System.Collections.Generic;
using CircuitLogic.models.Nodes;

namespace CircuitLogic.controllers
{
    public class CircuitIterator
    {
        private List<Node> InitNodes { get; set; }

        public CircuitIterator(List<Node> initNodes)
        {
            InitNodes = initNodes;
        }

        public void Run()
        {
            foreach (var node in InitNodes)
            {
                Console.WriteLine(node.Identifier);
                node.Run(node.Value);
            }
        }
    }
}