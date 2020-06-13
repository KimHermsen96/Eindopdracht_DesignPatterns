using CircuitLogic.controllers;
using CircuitLogic.controllers.Composite_pattern;

namespace CircuitLogic.models.Nodes
{
    public class Xor : Composite
    {
        public override void CalculateOutput(int value)
        {
            SavedValues.Add(value);
            if(SavedValues.Count == NumberOfInputNodes)
            {
                Value = SavedValues.Contains(0) && SavedValues.Contains(1) ? 1 : 0;
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
