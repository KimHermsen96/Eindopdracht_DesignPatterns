using CircuitLogic.controllers;
using CircuitLogic.controllers.Composite_pattern;

namespace CircuitLogic.models.Nodes
{
    public class Input : Composite
    {

        public override void CalculateOutput(int value)
        {
            Finished = true;
            Continue();
        }

        public override bool Accept(ValidNodeVisitor validNodeVisitor)
        {
            return validNodeVisitor.Visit(this);
        }
    }
}
