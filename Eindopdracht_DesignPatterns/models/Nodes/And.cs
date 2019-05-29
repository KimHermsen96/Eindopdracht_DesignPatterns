using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class And : INode
    {

        public int? firstValue { get; set; }

        public void Notify(INode sender, int value)
        {
            
            if (firstValue == null)
            {

            }

        }

        public string Identifier { get; set; }
        public List<string> TargetIdentifieers { get; set; }
    }
}
