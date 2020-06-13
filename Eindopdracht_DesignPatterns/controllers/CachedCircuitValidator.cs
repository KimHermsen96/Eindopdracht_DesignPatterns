using System.Collections.Generic;
using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers
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
        public void SetState()
        {
            if (CircuitStates.ContainsKey(Circuit.Name))
            {
                Circuit.State = CircuitStates[Circuit.Name];
            }
            else
            {
                CircuitValidator.SetState();
                CircuitStates.Add(Circuit.Name, Circuit.State);
            }
        }
    }
}
