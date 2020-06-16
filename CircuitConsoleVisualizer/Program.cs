﻿using CircuitLogic.controllers;
using CircuitLogic.models;
using System;
using CircuitLogic.controllers.State_pattern;
using CircuitLogic.models.Nodes;

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

                    singlecir.State.DoAction(singlecir);

                    if (singlecir.State is ValidCircuit) new ShowCircuitView(singlecir);
                  
                }
                //Choose another circuit or end the circuit
                EndCircuitView endCircuitView = new EndCircuitView();
                if (endCircuitView.EndCircuit()) endProgram = true;
            }
        }
    }
}
