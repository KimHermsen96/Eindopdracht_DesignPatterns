using CircuitLogic.controllers;
using CircuitLogic.models;
using System;
using System.Collections.Generic;
using CircuitLogic.controllers.State_pattern;
using CircuitLogic.models.Nodes;

namespace CircuitConsoleVisualizer
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            SingleCircuit circuit = new SingleCircuit();
           
            circuit.AllNodes.Add("and", new And(){Finished = true});

            circuit.Clear();

            
            
            CachedCircuitValidator proxyCircuitValidator = new CachedCircuitValidator();

            var endProgram = false;
            while (!endProgram)
            {
                //Choose file
                ChooseFileView chooseFileView = new ChooseFileView();

                //Create Circuit
                CircuitMaker circuitMaker = new CircuitMaker(chooseFileView.ChosenFile);
                Circuit singlecir = circuitMaker.MakeCircuit();
             
                if (singlecir != null)
                {
                    //Validate Circuit
                    CircuitValidator validator = new CircuitValidator(singlecir);
                    proxyCircuitValidator.Circuit = singlecir;
                    proxyCircuitValidator.CircuitValidator = validator;
                    proxyCircuitValidator.SetState();

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
                    ShowCircuitView showoutput = new ShowCircuitView(singlecir);
                }
                //Choose another circuit or end the circuit
                EndCircuitView endCircuitView = new EndCircuitView();
                if (endCircuitView.EndCircuit()) endProgram = true;
            }
        }
    }
}
