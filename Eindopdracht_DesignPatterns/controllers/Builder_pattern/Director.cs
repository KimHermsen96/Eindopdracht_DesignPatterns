using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Builder_pattern;

namespace Eindopdracht_DesignPatterns.controllers.Builder_pattern
{
    public class Director
    {

        private CircuitBuilder CircuitBuilder;

        public void SetCircuitBuilder(CircuitBuilder cb)
        {
            CircuitBuilder = cb; 
        }

        public Circuit GetCircuit()
        {
            return CircuitBuilder.GetCircuit(); 
        }


        public void ConstructCircuit()
        {
            CircuitBuilder.ConstructCircuit();
        }
    }
}
