using Eindopdracht_DesignPatterns.models.Nodes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuircuitVisualizer.ViewModel
{
    public class NodeViewModel : ViewModelBase
    {
        public string Identifier { get; set; }
        public int Value { get; set; }

        public NodeViewModel(Node _node)
        {
            Identifier = _node.Identifier;
            Value = _node.Value;
        }

       
        
    }
}
