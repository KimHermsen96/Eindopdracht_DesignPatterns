using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class And : Composite
    {
     
        public List<int> Values { get; set; }

        public And()
        {
            Values = new List<int>();
        }

        public override void CalculateOutput(int value)
        {

            //short circuit
            if(value == 0)
            {
                Value = 0; 
                Finished = true;
                Continue();
                return; 
            }

            Values.Add(value);
            //if two values came in and they were both not 0 then they were 1. 
            if (Values.Count == NumberOfInputNodes)
            {
                Value = 1;
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
