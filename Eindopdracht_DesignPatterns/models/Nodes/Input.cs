using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Input : Composite
    {
        public override void CalculateOutput(int value)
        {
            Finished = true;
            Continue();
        }

        public override bool ValidNode()
        {
            return true;
        }
    }
}
