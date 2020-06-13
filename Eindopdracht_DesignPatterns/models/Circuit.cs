using System.Collections.Generic;
using CircuitLogic.controllers.Composite_pattern;
using CircuitLogic.models.interfaces;
using CircuitLogic.models.Nodes;

namespace CircuitLogic.models
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
