using System;
using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers.State_pattern
{
    public class LoopCircuit : IState
    {
        public void DoAction(Circuit circuit)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Invalid Circuit due to loop");
            Console.WriteLine("---------------------------");
        }
    }
}
