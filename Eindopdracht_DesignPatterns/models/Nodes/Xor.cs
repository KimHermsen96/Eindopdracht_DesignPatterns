using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Xor : Node
    {
        public override void CalculateOutput(int value)
        {
            SavedValues.Add(value);
            if(SavedValues.Count == NumberOfInputNodes)
            {
                Value = SavedValues.Contains(0) && SavedValues.Contains(1) ? 1 : 0;
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
