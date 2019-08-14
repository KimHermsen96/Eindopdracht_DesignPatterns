using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitBuilder
    {
        private Dictionary<INode, List<INode>> Circuit; //lijst met nodes een edges
        private Dictionary<string, INode> AllNodes; //lijst van naam met bijbehorend type

        private NodeFactory nodeFactory;
        private Mediator mediator;

        public CircuitBuilder()
        {
            AllNodes = new Dictionary<string, INode>();
            Circuit = new Dictionary<INode, List<INode>>();

            nodeFactory = new NodeFactory();
            mediator = new Mediator();
        }
        

        public void CreateNodes(Dictionary<string, string> nodes)
        {
            foreach (var node in nodes)
            {
                var inode = nodeFactory.CreateNode(node.Key, node.Value);
                AllNodes.Add(node.Key, inode);
            }

            mediator.AllNodes = AllNodes;
        }

        public void CreateEdges(Dictionary<string, List<string>> edges)
        {
            foreach (var edge in edges)
            {
                INode node = AllNodes[edge.Key];
                Circuit.Add(node, new List<INode>());

                foreach (var targetn in edge.Value)
                {
                    INode targetNode = AllNodes[targetn];

                    List<INode> targetList = Circuit[node];
                    targetList.Add(targetNode);
                }
            }
        }

        public void ExecuteCircuit()
        {
            mediator.AllNodes = AllNodes;
            mediator.Circuit = Circuit;
            mediator.Execute();
        }
    }
}