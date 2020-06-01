
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : Composite, INode
    {
   
        //public string Identifier { get; set; }
        //public int Value { get; set; }

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

    }
}
