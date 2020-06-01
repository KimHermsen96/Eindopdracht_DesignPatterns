using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or : Composite
    {
        public string Identifier { get; set; }
        public int Value { get; set; } = 0;

        private List<int> InputValues { get; set; }


        public Or()
        {
            InputValues = new List<int>();
        }

        public override void CalculateOutput(int value)
        {
            //wordt gecheckt of er een input 1 is dan is de uitkomst altijd 1. short circuit
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
