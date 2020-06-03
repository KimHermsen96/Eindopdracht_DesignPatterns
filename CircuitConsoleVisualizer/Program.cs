using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.State;
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


            //Ask input 
            if (singlecir.State is ValidCircuit)
            {

                ChooseInputValues chooseInputValues = new ChooseInputValues();
                if (!chooseInputValues.UseDefault())
                    singlecir.Firsts.ForEach(n => chooseInputValues.SetInput(n));
            }
            //Run circuit
            singlecir.State.DoAction(singlecir);

            Console.ReadKey();

        }
    }
}
