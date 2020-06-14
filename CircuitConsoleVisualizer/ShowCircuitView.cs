using CircuitLogic.models;
using System;

namespace CircuitConsoleVisualizer
{
    public class ShowCircuitView
    {
        public ShowCircuitView(Circuit circuit)
        {
            foreach(var node in circuit.AllNodes) Console.WriteLine("Node: " + node.Key + "   Value: " + node.Value.Value.ToString());
        }
    }
}
