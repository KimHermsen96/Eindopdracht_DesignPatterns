using System.Collections.Generic;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CachedCircuitValidator : IValidator
    {
        public Circuit Circuit { get; set; }
        public CircuitValidator CircuitValidator { get; set; }
        private Dictionary<string, IState> CircuitStates { get; set; }
       
        public CachedCircuitValidator()
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
