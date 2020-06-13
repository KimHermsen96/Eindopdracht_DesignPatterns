using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Probe : Leaf
    {
        public override void CalculateOutput(int value)
        {
            Value = value;
        }

        public override bool Accept(ValidNodeVisitor validNodeVisitor)
        {
            return validNodeVisitor.Visit(this);
        }
    }
}
