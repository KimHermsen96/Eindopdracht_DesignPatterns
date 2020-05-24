using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public class SingleCircuit : Circuit
    {
       
        public override Dictionary<string, INode> AllNodes { get; set; }
        public override Dictionary<string, INode> CurrentCircuit { get; set; }

        public SingleCircuit()
        {
            AllNodes = new Dictionary<string, INode>();
            CurrentCircuit = new Dictionary<string, INode>();
        }
    }
}
