using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuircuitVisualizer.ViewModel
{
    public class CircuitViewModel
    {
        public List<Node> Firsts { get; set; }
        public CircuitViewModel(Circuit _circuit)
        {
            Firsts = _circuit.Firsts; 
        }
     
    }
}
