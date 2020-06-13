using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Nor : Composite
    {
        public override void CalculateOutput(int value)
        {
            SavedValues.Add(value);
            // short circuit when input is 1 output is 0 
            if(value == 1)
            {
                Value = 0; 
                Finished = true;
                Continue();
                return;
            }

            
            if(SavedValues.Count == NumberOfInputNodes)
            {
                Value = SavedValues.Contains(1) ? 0 : 1;
                Finished = true;
                Continue();
                return;
            }
        }

        public override bool ValidNode()
        {
            return NumberOfInputNodes == 2;
        }
    }
}
