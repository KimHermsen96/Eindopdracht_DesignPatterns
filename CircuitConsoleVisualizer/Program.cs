using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Proxy;
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

            CashedCircuitValidator proxyCircuitValidator = new CashedCircuitValidator();

            var endProgram = false;
            while (!endProgram)
            {

                //Choose file
                ChooseFileView ChooseFileView = new ChooseFileView();

                //Create Circuit
                CircuitMaker circuitMaker = new CircuitMaker(ChooseFileView.ChosenFile);
                CircuitTemplate singlecir = circuitMaker.MakeCircuit();

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

                //Run circuit
                singlecir.State.DoAction(singlecir);

                //Choose another circuit or end the circuit
                EndCircuitView endCircuitView = new EndCircuitView();
                if (endCircuitView.EndCircuit()) endProgram = true;
            }
        }
    }
}
