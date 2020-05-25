using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Mediator : IMediator 
    {


        public Dictionary<INode, List<INode>> Circuit { get; set; } //lijst met nodes een edges
        public Dictionary<string, INode> AllNodes { get; set; } //lijst van naam met bijbehorend type


        public Mediator()
        {
        }

        public void Execute()
        {

            foreach (var node in Circuit)
            {
                foreach (var connectedNode in node.Value)
                {
                    Console.WriteLine("value " + connectedNode.Identifier);
                    Notify(connectedNode, node.Key.Value);
                }

                Console.WriteLine("key " + node.Key.Identifier + " value " + node.Key.Value);
            }
        }

        public void Notify(INode sender, int value)
        {
            sender.CalculateOutput(value);
        }
    }
}
