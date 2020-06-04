using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or : Composite
    {
        private List<int> SavedValues { get; set; }
        public Or()
        {
            SavedValues = new List<int>();
        }

        public override void CalculateOutput(int _value)
        {
            //short circuit if the value is 1 the outcome is always 1 
            if (_value == 1)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }

            SavedValues.Add(_value);
            //0 stays 0. 
            if (SavedValues.Count == NumberOfInputNodes)
            {
                Finished = true;
                Continue();
                return;
            }

        }

        public override bool ValidNode()
        {
            return NumberOfInputNodes >= 2;
        }
    }
}
