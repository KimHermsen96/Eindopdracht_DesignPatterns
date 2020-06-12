using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers.State_pattern
{
    public class ValidCircuit : IState
    {
        private Circuit Circuit { get; set; }

        public void DoAction(Circuit circuit)
        {
            Circuit = circuit; 
            var circuitIterator = new CircuitIterator(Circuit.Firsts);
            circuitIterator.Run();
        }
    }
}
