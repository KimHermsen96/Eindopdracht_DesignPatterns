using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Eindopdracht_DesignPatterns.controllers;
using System.Collections.Generic;
using Eindopdracht_DesignPatterns.models;

namespace CuircuitVisualizer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand ChooseFileCommand { get; set; }
        public ICommand RunCommand { get; set; }
        public ICommand ChooseInputCommand { get; set; }

        public ObservableCollection<FileViewModel> Files { get; set; }
        public ObservableCollection<NodeViewModel> Inputs { get; set; }

        public ObservableCollection<NodeViewModel> Firsts { get; set; }

        public CircuitViewModel Circuitvm { get; set; }

        public MainViewModel()
        {

            //ChooseFileCommand = new RelayCommand(ChooseFile);
            RunCommand = new RelayCommand(RunCircuit);
            ChooseInputCommand = new RelayCommand(ChooseInput);
            ChooseFileCommand = new RelayCommand(ChooseFile);
            ViewDataProvider provider = new ViewDataProvider();

            //get file names. 
            Files = new ObservableCollection<FileViewModel>();
            provider.GetFileNames().ForEach(n => Files.Add(new FileViewModel(n)));

            //Create circuit 
            CircuitMaker circuitMaker = new CircuitMaker("Circuit1_FullAdder.txt");
            Circuit singlecir = circuitMaker.MakeCircuit();

            //get InputNodes
            //Circuitvm = new CircuitViewModel(singlecir);

            Firsts = new ObservableCollection<NodeViewModel>();
            singlecir.Firsts.ForEach(n => Firsts.Add(new NodeViewModel(n)));

        }

        private void ChooseFile()
        {
        }

        private void ChooseInput()
        {
           
        }

        private void RunCircuit()
        {
            //CircuitFileReader fileReader = new CircuitFileReader();
            //string[] fileByLine = fileReader.Readfile(chosenFile);

        }

    }
}