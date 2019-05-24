using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Not : INode, IEdge
    {
        public List<string>TargetIdentifieers { get; set; }
        public string Identifier { get; set; }


        public void Notify(INode sender, string message)
        {
            throw new NotImplementedException();
        }
    }
}
