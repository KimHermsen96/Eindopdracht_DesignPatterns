using System;
using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers.State_pattern
{
    public class UnreachableProbesCircuit : IState
    {
        public void DoAction(Circuit circuit)
        {

            Console.WriteLine("Invalid Circuit due to unreachable probes ");
        }
    }
}
