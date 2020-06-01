using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Probe : Leaf, INode
    {

        public string Identifier { get; set; }
        public int Value { get; set; }
        public List<IComponent> ComponentList { get; set; }

        public void CalculateOutput(int value)
        {
            Value = value;
        }

    }
}
