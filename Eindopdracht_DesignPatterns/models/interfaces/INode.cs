using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public abstract class INode
    {
        public string Identifier { get; set; }
        public int Value { get; set; }
        public List<string> TargetIdentifieers { get; set; }

        public INode()
        {
            TargetIdentifieers = new List<string>();
        }
        public void calculateOutput(int value) { }
    }
}