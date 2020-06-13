using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers.State_pattern
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
