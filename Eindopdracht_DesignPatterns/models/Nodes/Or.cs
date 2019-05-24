using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Or :INode , IEdge
    {
        public List<string> TargetIdentifieers { get; set; }
        public string Identifier { get; set; }


        public void Notify(INode sender, string e)
        {
            foreach (string el in TargetIdentifieers)
            {
                sender.Notify(this, e);
            }
        }
    }
}
