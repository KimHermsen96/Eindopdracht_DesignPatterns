using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Director
    {

        private CircuitBuilder CircuitBuilder;

        public void SetCircuitBuilder(CircuitBuilder cb)
        {
            CircuitBuilder = cb; 
        }

        public Dictionary<string, INode> GetCircuit()
        {
            return CircuitBuilder.GetCircuit(); 
        }


        //public void ConstructCircuit()
        //{
        //    CircuitBuilder.
        //}
    }
}
