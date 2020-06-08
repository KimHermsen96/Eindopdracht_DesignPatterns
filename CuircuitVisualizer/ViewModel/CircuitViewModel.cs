using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.Nodes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuircuitVisualizer.ViewModel
{
    public class CircuitViewModel : ViewModelBase
    {

        public ObservableCollection<NodeViewModel> Firsts { get; set; }
        public CircuitViewModel(Circuit _circuit)
        {
            Firsts = new ObservableCollection<NodeViewModel>();
            _circuit.Firsts.ForEach(n => Firsts.Add(new NodeViewModel(n)));
        }
     
    }
}
