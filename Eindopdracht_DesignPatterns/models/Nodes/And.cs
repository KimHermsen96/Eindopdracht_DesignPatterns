﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class And : Composite, INode
    {
        public int? firstValue { get; set; }
        public string Identifier { get; set; }

        public int Value { get; set; }
        public List<int> Values { get; set; }

        public And()
        {
            Values = new List<int>();
        }

        public void CalculateOutput(int value)
        {

            Values.Add(value);
            Value = GetValue();
            //            Value = value;
            //            if (_firstValue == null)
            //            {
            //                _firstValue = Value;
            //            }
            //
            //            if (_firstValue == 1 && value == 1)
            //            {
            //                Value = 1;
            //            }
            //            else
            //            {
            //                Value = 0;
            //            }
        }
        private int GetValue()
        {
            foreach (var v in Values)
            {
                if (v == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
