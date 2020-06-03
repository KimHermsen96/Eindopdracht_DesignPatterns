
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : Composite
    {
        public override void CalculateOutput(int value)
        {
            if (value == 1)
            {
                Value = 0;
            }
            else
            {
                Value = 1;
            }

            Finished = true;
            Continue();
            return;
        }
        public override bool ValidNode()
        {
            return NumberOfInputNodes == 1;
        }

    }
}
