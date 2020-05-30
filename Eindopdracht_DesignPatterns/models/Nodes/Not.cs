
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : Composite, INode
    {
   
        public string Identifier { get; set; }
        public int Value { get; set; }

        public void CalculateOutput(int value)
        {
            if (value == 1)
            {
                Value = 0;
            }
            else
            {
                Value = 1;
            }
        }

    }
}
