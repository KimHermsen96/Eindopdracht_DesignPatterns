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

        public void DoAction(Circuit _circuit)
        {
            Circuit = _circuit; 
            CicruitIterator circuitIterator = new CicruitIterator(Circuit.Firsts);
            circuitIterator.Run();
        }
    }
}
