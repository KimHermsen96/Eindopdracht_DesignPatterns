using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Probe : INode
    {
        public string Identifier { get; set; }
        public string[] TargetIdentifieers { get; set; }


        public void Notify(INode sender, string message)
        {
            throw new NotImplementedException();
        }

       
    }
}
