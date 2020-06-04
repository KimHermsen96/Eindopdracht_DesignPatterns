
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : Composite
    {
        public override void CalculateOutput(int _value)
        {
            Value = _value == 1 ? 0 : 1; 
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
