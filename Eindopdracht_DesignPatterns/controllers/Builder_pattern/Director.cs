using CircuitLogic.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircuitLogic.models;
using CircuitLogic.controllers.Builder_pattern;

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
