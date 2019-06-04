using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Mediator : IMediator 
    {
        private Dictionary<INode, List<INode>> allElements;
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
            allElements = new Dictionary<INode, List<INode>>();

        }

        public void Execute()
        {

            foreach (var el in allElements)
            {
                Console.WriteLine("key" + el.Key.Identifier);

                foreach (var a in el.Value)
                {
                    Console.WriteLine("value " +  a.Identifier);

                    Notify(a, a.Value);
                }

            }
//            foreach (var element in allElements)
//            {
//                Notify(element.Value, element.Value.Value);
//            }
        }

        public void Notify(INode sender, int value)
        {
            sender.CalculateOutput(value);
        }

        public void AddElement(INode node)
        {
            allElements.Add(node, new List<INode>());
        }

        public void AddEdge(string nodeIdentifier, string edgeIdentifier)
        {

            foreach (var el in allElements)
            {
                if (el.Key.Identifier == nodeIdentifier)
                {
                    foreach (var a in allElements)
                    {
                        if (a.Key.Identifier == edgeIdentifier)
                        {
                            allElements[el.Key].Add(a.Key);
                        }
                    }
                }
            }
        }



    }
}
