using CircuitLogic.models.interfaces;
using System.Collections.Generic;
using CircuitLogic.controllers;
using CircuitLogic.controllers.Composite_pattern;

namespace CircuitLogic.models.Nodes
{
    public class Or : Composite
    {
        public override void CalculateOutput(int value)
        {
            //short circuit if the value is 1 the outcome is always 1 
            if (value == 1)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }

            SavedValues.Add(value);
            //0 stays 0. 
            if (SavedValues.Count == NumberOfInputNodes)
            {
                Value = 0;
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
