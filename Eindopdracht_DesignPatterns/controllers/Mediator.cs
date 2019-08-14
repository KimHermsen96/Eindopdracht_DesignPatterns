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


//        private static Mediator _instance;

//        public static Mediator instance
//        {
//            get
//            {
//                if (_instance == null)
//                { 
//                    _instance = new Mediator();
//                }
//
//                return _instance;
//            }
//        }

        public Mediator()
        {
            AllNodes = new Dictionary<string, INode>();
            Circuit = new Dictionary<INode, List<INode>>();
        }

        public void Execute()
        {

            foreach (var node in Circuit)
            {
                foreach (var connectedNode in node.Value)
                {
                    Console.WriteLine("value " +  connectedNode.Identifier);
                    Notify(connectedNode, node.Key.Value);
                }

                Console.WriteLine("key " + node.Key.Identifier +  " value " + node.Key.Value);
            }
        }

        public void Notify(INode sender, int value)
        {
            sender.CalculateOutput(value);
        }

        public bool CheckIfValid()
        {
            if (!Connected())
            {

                Console.WriteLine("Circuit is not connected");
                return Connected();

            }
            return true; 
        }

        private bool Connected()
        {
            foreach (var element in AllNodes)
            {

                /// if false.. returned false als het element niet connected is. 
                if (!CheckOneElement(element.Key, element.Value)) return false;
            }
            return true;
        }

        public bool CheckOneElement(string key, INode value)
        {
            foreach (var edge in Circuit)
            {
                //hier check ik of de huidige nodes wel in de lijst voorkomen. 
                if (edge.Key.Identifier == key || value is Probe)    return true;
                
            }
            //als niet beide keys in de lijst voorkomen betekend dit dat de er een node niet verbonden is. 
            //dus is de ding fout. 
            return false;
        }
    }
}
