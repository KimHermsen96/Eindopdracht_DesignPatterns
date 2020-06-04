using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Nor : Node
    {
        public override void CalculateOutput(int _value)
        {
            SavedValues.Add(_value);
            // short circuit when value is 1 input is 0 
            if(_value == 1)
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
