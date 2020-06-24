﻿using System;
using System.Collections.Generic;
using CircuitLogic.models.Nodes;

namespace CircuitLogic.controllers
{
    public class NodeFactory
    {
        private readonly Dictionary<string, Type> _types;
        private static NodeFactory _instance;

        //Singleton
        public static NodeFactory Instance
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
                { "NAND", typeof(Nand) },
                { "NOR", typeof(Nor) },
                { "XOR", typeof(Xor) },
                { "INPUT_HIGH", typeof(Input) },
                { "INPUT_LOW",typeof(Input) },
                { "PROBE", typeof(Probe) }
            };
        }

        public Node CreateNode(string identifier, string descriptor)
        {
            Type t = _types[descriptor];
            Node node = (Node) Activator.CreateInstance(t);
            node.Identifier = identifier;

            if (t == typeof(Input))
            {
                int value = (descriptor == "INPUT_HIGH") ? 1 : 0; 
                node.Value = value;
            }
            return node; 
        }
    }
}