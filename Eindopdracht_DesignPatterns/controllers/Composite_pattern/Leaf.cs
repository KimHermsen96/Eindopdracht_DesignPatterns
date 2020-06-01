﻿using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Composite_pattern
{
    public class Leaf : Node, IComponent
    {
        public List<IComponent> ComponentList { get; set; }

        public void AddComposite(IComponent edge)
        {
        }

        public override void CalculateOutput(int value)
        {
        }
    }
}