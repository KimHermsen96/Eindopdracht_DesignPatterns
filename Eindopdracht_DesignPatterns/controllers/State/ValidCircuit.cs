using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using Eindopdracht_DesignPatterns.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.State
{
    public class ValidCircuit : IState
    {
        private Circuit Circuit { get; set; }
        private List<int> AllInputs { get; set; }
        public void DoAction(Circuit circuit)
        {
            AllInputs = new List<int>();
            Mediator mediator = new Mediator(circuit);
            mediator.Execute();
        }

        private void AskForInput()
        {
            InputView inputview = new InputView();
            var numOfInputs = 0;
            if (inputview.UseUserInput()) numOfInputs = CheckNumOfInputs();

            for (int i = 0; i < numOfInputs; i++) AllInputs.Add(inputview.AskInput());
        }

        private int CheckNumOfInputs()
        {
            var number = 0;
            foreach (var node in Circuit.AllNodes)
            {
                if (node.Value == typeof(Input)) number++;
            }
            return number;
        }
    }
}
