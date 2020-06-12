using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.State_pattern;

namespace CircuitConsoleVisualizer
{
    public class Program
    {
        static void Main(string[] args)
        {

            CachedCircuitValidator proxyCircuitValidator = new CachedCircuitValidator();

            var endProgram = false;
            while (!endProgram)
            {

                //Choose file
                ChooseFileView chooseFileView = new ChooseFileView();

                //Create Circuit
                CircuitMaker circuitMaker = new CircuitMaker(chooseFileView.ChosenFile);
                Circuit singlecir = circuitMaker.MakeCircuit();


                //Validate Circuit
                CircuitValidator validator = new CircuitValidator(singlecir);
                proxyCircuitValidator.Circuit = singlecir;
                proxyCircuitValidator.CircuitValidator = validator;

                //get currentState
                singlecir.State = proxyCircuitValidator.CheckState();
               
                //Ask input 
                if (singlecir.State is ValidCircuit)
                {
                    ChooseInputValues chooseInputValues = new ChooseInputValues();
                    if (!chooseInputValues.UseDefault())
                        singlecir.Firsts.ForEach(n => chooseInputValues.SetInput(n));
                }
                Console.Clear();

                //Run circuit
                singlecir.State.DoAction(singlecir);

                //Choose another circuit or end the circuit
                EndCircuitView endCircuitView = new EndCircuitView();
                if (endCircuitView.EndCircuit()) endProgram = true;
            }
        }
    }
}
