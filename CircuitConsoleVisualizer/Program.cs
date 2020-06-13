using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models;
using System;
using Eindopdracht_DesignPatterns.controllers.State_pattern;
using Eindopdracht_DesignPatterns.models.Nodes;

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

                //Choose another circuit or end the circuit
                EndCircuitView endCircuitView = new EndCircuitView();
                if (endCircuitView.EndCircuit()) endProgram = true;
            }
        }
    }
}
