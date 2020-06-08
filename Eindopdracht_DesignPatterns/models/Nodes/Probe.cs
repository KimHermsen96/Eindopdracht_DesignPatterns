using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Probe : Leaf
    {
        public override void CalculateOutput(int value)
        {
        }

        public override bool ValidNode()
        {
            return true;
        }
    }
}
