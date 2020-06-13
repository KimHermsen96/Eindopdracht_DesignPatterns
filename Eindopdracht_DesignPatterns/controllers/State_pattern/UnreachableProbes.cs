using System;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.State_pattern
{
    public class UnreachableProbes : IState
    {
        public void DoAction(Circuit circuit)
        {

            Console.WriteLine("Invalid Circuit due to unreachable probes ");
        }
    }
}
