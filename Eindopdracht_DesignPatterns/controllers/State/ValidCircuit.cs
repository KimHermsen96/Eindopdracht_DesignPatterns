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
        private InputView InputView { get; set; }
        private Circuit Circuit { get; set; }
        public void DoAction(Circuit _circuit)
        {
            InputView = new InputView();
            Circuit = _circuit; 
            UseDefaultOrInput();
            Mediator mediator = new Mediator(_circuit);
            mediator.Execute();
        }

        private void UseDefaultOrInput()
        {
            if (InputView.UseUserInput()) AskInput();
        }

        private void AskInput()
        {
            var userInput = 0; 
            foreach (var node in Circuit.AllNodes)
            {
                if (node.Value.GetType() == typeof(Input))
                {
                    userInput = InputView.AskInput(node.Key);
                    node.Value.Value = userInput;
                } 
            }
        }
    }
}
