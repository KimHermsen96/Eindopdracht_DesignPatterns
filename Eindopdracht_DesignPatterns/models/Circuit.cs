using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public abstract class Circuit 
    {
        public abstract Dictionary<string, INodeasdfds> AllNodes { get; set; }
        public abstract Dictionary<string, INodeasdfds> CurrentCircuit { get; set; }
    }
}
