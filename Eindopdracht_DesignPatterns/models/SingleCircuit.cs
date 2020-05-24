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
       
        public override Dictionary<string, INodeasdfds> AllNodes { get; set; }
        public override Dictionary<string, INodeasdfds> CurrentCircuit { get; set; }

        public SingleCircuit()
        {
            AllNodes = new Dictionary<string, INodeasdfds>();
            CurrentCircuit = new Dictionary<string, INodeasdfds>();
        }
    }
}
