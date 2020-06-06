using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Eindopdracht_DesignPatterns.controllers;
using System.Collections.Generic;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.controllers.Proxy;

namespace CuircuitVisualizer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand RunCommand { get; set; }
        public ObservableCollection<NodeViewModel> Firsts { get; set; }
        private CashedCircuitValidator ProxyCircuitValidator { get; set; }
        private CircuitTemplate Singlecir { get; set; }
        public MainViewModel()
        {
            //ChooseFileCommand = new RelayCommand(ChooseFile);
            RunCommand = new RelayCommand(RunCircuit);

            //Create circuit 
            CircuitMaker circuitMaker = new CircuitMaker("Circuit1_FullAdder.txt");
            Singlecir = circuitMaker.MakeCircuit();

            //get InputNodes
            //Circuitvm = new CircuitViewModel(singlecir);
            Firsts = new ObservableCollection<NodeViewModel>();
            Singlecir.Firsts.ForEach(n => Firsts.Add(new NodeViewModel(n)));

            //Create validator
            ProxyCircuitValidator = new CashedCircuitValidator();
        }

        private void RunCircuit()
        {
            CircuitValidator validator = new CircuitValidator(Singlecir);
            ProxyCircuitValidator.Circuit = Singlecir;
            ProxyCircuitValidator.CircuitValidator = validator;

            //get currentState
            Singlecir.State = ProxyCircuitValidator.CheckState();

            //Run circuit
            Singlecir.State.DoAction(Singlecir);
        }
    }
}