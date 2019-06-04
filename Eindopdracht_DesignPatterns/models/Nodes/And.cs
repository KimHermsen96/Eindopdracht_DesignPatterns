using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class And : INode
    {
        private int? _firstValue { get; set; }
        public string Identifier { get; set; }
        public int Value { get; set; }

        public void CalculateOutput(int value)
        {
            Value = value;
            if (_firstValue == null)
            {
                _firstValue = Value;
            }
        }

    }
}
