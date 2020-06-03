using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitConsoleVisualizer
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Choose file
            ChooseFileView ChooseFileView = new ChooseFileView();

            //Create Circuit
            CircuitMaker circuitMaker = new CircuitMaker(ChooseFileView.ChosenFile);
            Circuit singlecir = circuitMaker.MakeCircuit();




            CircuitValidator validator = new CircuitValidator(singlecir);
            singlecir.State = validator.CheckState();
            singlecir.State.DoAction(singlecir);
            CicruitIterator circuitIterator = new CicruitIterator(singlecir.Firsts);
            circuitIterator.Run();




        }
    }
}
