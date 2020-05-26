using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or :  INode
    {
        public string Identifier { get; set; }
        public int Value { get; set; } = 0;

        public void CalculateOutput(int value)
        {
            if (value == 1)
            {
                Value = 1;
            }
        }
    }
}
