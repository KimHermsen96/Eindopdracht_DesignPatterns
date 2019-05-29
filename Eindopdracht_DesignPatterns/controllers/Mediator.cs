﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Mediator : IMediator 
    {
        private  Dictionary<string, INode> allElements;
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

        }

        public void Execute()
        {

            foreach (var element in allElements)
            {
                Console.WriteLine(element);

            }
        }

        public void Notify(INode sender, int value)
        {
            

        }

        public void AddElement(INode node, string identifier)
        {
            allElements.Add(identifier, node);
        }

        public void AddEdge(string nodeIdentifier, string edgeIdentifier)
        {
            INode item = allElements[nodeIdentifier];
            item.TargetIdentifieers.Add(edgeIdentifier);
        }
    }
}
