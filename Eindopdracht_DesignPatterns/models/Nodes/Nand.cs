using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Nand : Node
    {
        public override void CalculateOutput(int _value)
        {
            //short circuit if incoming value is 0 value is 0
            if( _value == 0)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }

            if (SavedValues.Count == NumberOfInputNodes)
            {
                Value = SavedValues.Contains(0) ? 1 : 0;
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
