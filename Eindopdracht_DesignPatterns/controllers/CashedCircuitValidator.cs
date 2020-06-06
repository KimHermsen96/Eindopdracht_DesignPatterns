using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Proxy
{
    public class CashedCircuitValidator : IValidator
    {
        public CircuitTemplate Circuit { get; set; }
        public CircuitValidator CircuitValidator { get; set; }
        private Dictionary<string, IState> CircuitStates { get; set; }


       
        public CashedCircuitValidator()
        {
            CircuitStates = new Dictionary<string, IState>();
        }
        public IState CheckState()
        {
            if (CircuitStates.ContainsKey(Circuit.Name))
            {
                return CircuitStates[Circuit.Name];
            }

            IState currentState = CircuitValidator.CheckState();
            CircuitStates.Add(Circuit.Name, currentState);
            return CircuitValidator.CheckState();
        }
    }
}
