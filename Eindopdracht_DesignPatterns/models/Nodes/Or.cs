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
        public int? firstValue { get; set; }
        public string Identifier { get; set; }
        public List<string> TargetIdentifieers { get; set; }
        public void calculateOutput(int value)
        {
            if (firstValue == null)
            {
                firstValue = value;
            }
        }
    }
}
