using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.controllers
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