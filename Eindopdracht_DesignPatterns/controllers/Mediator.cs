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
        private Dictionary<INode, List<INode>> edges;
        private Dictionary<string, INode> allElements;
        private static Mediator _instance;

        public static Mediator instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Mediator();
                }

                return _instance;
            }
        }

        public Mediator()
        {
            allElements = new Dictionary<string, INode>();
            edges = new Dictionary<INode, List<INode>>();
        }

        public void Execute()
        {

            foreach (var node in edges)
            {
                

                foreach (var connectedNode in node.Value)
                {
//                    Console.WriteLine("value " +  connectedNode.Identifier);

                    Notify(connectedNode, node.Key.Value);
                }

                Console.WriteLine("key" + node.Key.Identifier +  " value " + node.Key.Value);
            }
        }

        public void Notify(INode sender, int value)
        {
            sender.CalculateOutput(value);
        }

        public void AddElement(string descriptor, INode node )
        {
           allElements.Add(descriptor, node);
        }
        

        public void AddEdge(string nodeIdentifier, string edgeIdentifier)
        {
            INode node = allElements[nodeIdentifier];
            INode targetNode = allElements[edgeIdentifier];

            if (!edges.ContainsKey(node))
            {
                edges.Add(node, new List<INode>());
            }

            List<INode> targetList = edges[node];
            targetList.Add(targetNode);
            
        }
    }
}
