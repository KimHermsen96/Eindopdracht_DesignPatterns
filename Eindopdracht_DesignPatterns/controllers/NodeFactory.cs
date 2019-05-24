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
        private Mediator mediator;

        public NodeFactory(Mediator mediator)
        {
            this.mediator = mediator;
            _types = new Dictionary<string, Type>();
        }

        public void CreateCircuit(string identifier, String descriptor)
        {
            var value = "";
            if (descriptor == "INPUT_HIGH" || descriptor == "INPUT_LOW")
            {
                value = descriptor; //?hoe deze value nog toeveogen??
                descriptor = "Input";
            }
            CreateNodes(identifier, descriptor, value);
        }

        public void CreateNodes(string identifier, string descriptor, string value)
        {
            string sub  = descriptor.Substring(0, 1).ToUpper() + descriptor.Substring(1).ToLower();
            Type t = Type.GetType("Eindopdracht_DesignPatterns.models.Nodes." + sub);
            INode node = (INode) Activator.CreateInstance(t);
            node.Identifier = identifier;
            mediator.AddElement(node, identifier);
        }
    }
}
//
//switch (descriptor)
//{
//case "AND":
//new And()
//{
//Identifier = identifier
//};
//
//break;
//case "NOT":
//new Not()
//{
//Identifier = identifier
//};
//break;
//case "OR":
//new Or()
//{
//Identifier = identifier
//};
//break;
//case "INPUT_LOW": 
//case "INPUT_HIGH":
//new Input()
//{
//Identifier = identifier,
//Descriptor = descriptor
//};
//break;
//case "PROBE":
//Console.WriteLine("Case 2");
//break;
//default:
//Console.WriteLine("Default case");
//break;
//}
