using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public abstract class INode : IMediator
    {
        public string Identifier { get; set; }
        public List<string> TargetIdentifieers { get; set; }

        public INode()
        {
            TargetIdentifieers = new List<string>();
        }

        public void Notify(INode sender, int message)
        {
            throw new NotImplementedException();
        }
    }
}