using CircuitLogic.models;

namespace CircuitLogic.controllers.Builder_pattern
{
    public class Director
    {
        
        private CircuitBuilder _circuitBuilder;

        public void SetCircuitBuilder(CircuitBuilder cb)
        {
            _circuitBuilder = cb; 
        }

        public Circuit GetCircuit()
        {
            return _circuitBuilder.GetCircuit(); 
        }


        public void ConstructCircuit()
        {
            _circuitBuilder.ConstructCircuit();
        }
    }
}
