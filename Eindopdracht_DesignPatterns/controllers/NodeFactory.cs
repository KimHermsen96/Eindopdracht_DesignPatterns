using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class NodeFactory
    {
        private Dictionary<string, Type> _types;
        private static NodeFactory _instance;

        public static NodeFactory instance
        {
            get
            {
                if (_instance == null) _instance = new NodeFactory();
                return _instance;
            }
        }

        public NodeFactory( )
        {
      
            _types = new Dictionary<string, Type>()
            {
                { "AND", typeof(And) },
                { "OR", typeof(Or)  },
                { "NOT", typeof(Not) },
                { "INPUT_HIGH", typeof(Input) },
                { "INPUT_LOW",typeof(Input) },
                { "PROBE", typeof(Probe) }
            };
        }

        public INode CreateNode(string identifier, string descriptor)
        {
            Type t = _types[descriptor];
            INode node = (INode) Activator.CreateInstance(t);
            node.Identifier = identifier;

            if (t == typeof(Input))
            {
                int value = (descriptor == "INPUT_HIGH") ? 1 : 0; 
                node.Value = value;
            }
            return node; 
            //mediator.AddElement(node, identifier);
        }
    }
}