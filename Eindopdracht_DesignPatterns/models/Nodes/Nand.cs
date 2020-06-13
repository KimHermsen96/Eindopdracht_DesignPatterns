using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Nand : Composite
    {
        public override void CalculateOutput(int value)
        {
            //short circuit if incoming value is 0 value is 0
            if( value == 0)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }

            if (SavedValues.Count == NumberOfInputNodes)
            {
                Value = SavedValues.Contains(0) ? 1 : 0;
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
