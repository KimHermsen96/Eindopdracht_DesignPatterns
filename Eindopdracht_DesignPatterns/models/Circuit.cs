using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.models
{
    public abstract class Circuit : Composite 
    { 
        public abstract string Name { get; set; }
        public abstract void ClearCircuit();
        public abstract Dictionary<string, Node> AllNodes { get; set; }
        public abstract List<Node> Firsts { get; set; }
        public abstract IState State { get; set; }
    }
}
