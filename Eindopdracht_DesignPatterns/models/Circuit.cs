﻿using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public abstract class Circuit : Composite 
    { 
        public abstract Dictionary<string, IComponent> AllNodes { get; set; }
        public abstract List<Node> Firsts { get; set; }
        public abstract IState State { get; set; }
    }
}
