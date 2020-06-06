using Eindopdracht_DesignPatterns.models.Nodes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CuircuitVisualizer.ViewModel
{
    public class NodeViewModel : ViewModelBase
    {
        public string Identifier { get; set; }
        public int _value { get; set; }
        private Node Node {get; set;}

        public ICommand ChangeInputCommand => new RelayCommand(() => Value = Value == 1 ? 0 : 1);
 
        public NodeViewModel(Node _node)
        {
            Identifier = _node.Identifier;
            Node = _node; 
            Value = _node.Value;
        }

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                Node.Value = _value;
                RaisePropertyChanged();
            }
        }
    }
}
