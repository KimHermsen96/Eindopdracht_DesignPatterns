using CircuitLogic.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitConsoleVisualizer
{
    public class ShowCircuitView
    {
        public ShowCircuitView(Circuit circuit)
        {
            foreach(var node in circuit.AllNodes) Console.WriteLine("Key " + node.Key + " Value " + node.Value.Value.ToString());
        }
    }
}
