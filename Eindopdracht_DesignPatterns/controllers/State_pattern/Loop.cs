using System;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.State_pattern
{
    public class Loop : IState
    {
        public void DoAction(Circuit circuit)
        {
            Console.WriteLine("Invalid Circuit due to loop"); 
        }
    }
}
