using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or :  Composite, INode
    {
        public string Identifier { get; set; }
        public int Value { get; set; } = 0;

        public void CalculateOutput(int value)
        {
            if (value == 1)
            {
                Value = 1;
            }
        }
    }
}
