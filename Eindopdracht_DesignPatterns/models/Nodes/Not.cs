
using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : Composite
    {
        public override void CalculateOutput(int value)
        {
            Value = value == 1 ? 0 : 1; 
            Finished = true;
            Continue();
            return;
        }

        public override bool Accept(ValidNodeVisitor validNodeVisitor)
        {
            return validNodeVisitor.Visit(this);
        }
    }
}
