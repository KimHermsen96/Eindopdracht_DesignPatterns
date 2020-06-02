using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or : Composite
    {
        private List<int> InputValues { get; set; }
        public Or()
        {
            InputValues = new List<int>();
        }

        public override void CalculateOutput(int value)
        {
            //short circuit if the value is 1 the outcome is always 1 
            if (value == 1)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }

            InputValues.Add(value);

            if (InputValues.Count == NumberOfInputs)
            {
                Finished = true;
                Continue();
                return;
            }

        }
       
    }
}
