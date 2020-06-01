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
            //korter circuit. 
            if(value == 0)
            {
                Value = 0; 
                Finished = true;
                Continue();
                return; 
            }

            Values.Add(value);
            
            //als er twee waardes binnen zijn gekomen en ze niet in de 0 ding zijn gekomen dan zijn ze dus beide 1. 
            if (Values.Count == NumberOfInputs)
            {
                Value = 1;
                Finished = true;
                Continue();
                return;
            }
        }
    }
}
