using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Mediator : IMediator 
    {

        private Circuit Circuit { get; set; } //lijst met nodes een edges
        public Mediator(Circuit _circuit)
        {
            Circuit = _circuit; 
        }

        //public void Execute()
        //{
        //    foreach (var node in Circuit.CurrentCircuit)
        //    {
        //        foreach (var connectedNode in node.Value)
        //        {
        //            Console.WriteLine("value " + connectedNode.Identifier);
        //            Notify(connectedNode, node.Key.Value);
        //        }
        //        Console.WriteLine("key " + node.Key.Identifier + " value " + node.Key.Value);
        //    }
        //}

        public void Notify(IStrategy sender, int value)
        {
            sender.CalculateOutput(value);
        }
    }
}
