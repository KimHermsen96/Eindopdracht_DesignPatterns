using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CircuitLogic.controllers;
using System.Linq;
using CuircuitVisualizer.Services;
using CircuitLogic.controllers.Composite_pattern;
using CircuitLogic.models;
using CircuitLogic.models.Nodes;

namespace CuircuitVisualizer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand RunCommand { get; set; }
        public ObservableCollection<NodeViewModel> Firsts { get; set; }
        public ObservableCollection<NodeViewModel> AllNodes { get; set; }
        private CachedCircuitValidator ProxyCircuitValidator { get; set; }
        private Circuit Singlecir { get; set; }
        public MainViewModel()
        {
            //ChooseFileCommand = new RelayCommand(ChooseFile);
            RunCommand = new RelayCommand(RunCircuit);

            //Create circuit 
            CircuitMaker circuitMaker = new CircuitMaker("Circuit1_FullAdder.txt");
            Singlecir = circuitMaker.MakeCircuit();

            //Get InputNodes
            Firsts = new ObservableCollection<NodeViewModel>();
            Singlecir.Firsts.ForEach(el => Firsts.Add(new NodeViewModel(el)));

            //Get all nodes
            AllNodes = new ObservableCollection<NodeViewModel>();
            foreach (var node in Singlecir.AllNodes) AllNodes.Add(new NodeViewModel(node.Value));
         

            //Create validator
            ProxyCircuitValidator = new CachedCircuitValidator();
        }

        private void RunCircuit()
        {
            GraphVisualizer visualizer = new GraphVisualizer();
            CircuitValidator validator = new CircuitValidator(Singlecir);
            ProxyCircuitValidator.Circuit = Singlecir;
            ProxyCircuitValidator.CircuitValidator = validator;
            ProxyCircuitValidator.SetState();

            //Run circuit
            Singlecir.State.DoAction(Singlecir);
            //remove old items in list. 
            AllNodes.Clear();

            foreach (var node in Singlecir.AllNodes)
            {
                CreateNodeInGraph(node.Key, node.Value, visualizer);
                AllNodes.Add(new NodeViewModel(node.Value));
            }

            //Create image of circuit
            visualizer.Render();

            //clear circuit 
            Singlecir.Clear();
        }

        private void CreateNodeInGraph(string name,  Node node, GraphVisualizer visualizer)
        {
            visualizer.AddNode(node.Identifier, node.Identifier);

            if (node is Composite)
            {
                var composite = (Composite) node;

                foreach (var n in composite.ComponentList.Cast<Node>())
                {
                    visualizer.AddEdge(node.Identifier, n.Identifier, node.Value.ToString());
                }
            }
        }
    }
}