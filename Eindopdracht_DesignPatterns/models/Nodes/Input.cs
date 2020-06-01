using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Input : Composite
    {


        //public string Identifier { get; set; }
        //public int Value { get; set; }

        public Input() : base()
        {
        }

        public override void CalculateOutput(int value)
        {
            Finished = true;
            Continue();
        }
        //protected void Continue()
        //{
        //    foreach (var node in ComponentList)
        //    {
        //        var n = (Node)node;
        //        n.Run(Value);
        //    }
        //}
    }
}
