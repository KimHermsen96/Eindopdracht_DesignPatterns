using System.Linq;
using CircuitLogic.controllers;
using CircuitLogic.controllers.Composite_pattern;

namespace CircuitLogic.models.Nodes
{
    public class And : Composite
    {

        public override void CalculateOutput(int value)
        {
            //short circuit
            if(value == 0)
            {
                Value = 0; 
                Finished = true;
                Continue();
                return; 
            }

            SavedValues.Add(value);
            //if two values came in and they were both not 0 then they were 1. 
            if (SavedValues.Count == NumberOfInputNodes)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }
        }

        public override bool Accept(ValidNodeVisitor validNodeVisitor)
        {
           return validNodeVisitor.Visit(this);
        }
    }
}
