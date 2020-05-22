using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public class SingleCircuit 
    {
        public Dictionary<string, INode> AllNodes{ get; set; }
        public Dictionary<string, INode> Circuit { get; set; }

        public SingleCircuit()
        {
            AllNodes = new Dictionary<string, INode>();
            Circuit = new Dictionary<string, INode>();
        }
    }
}
