using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface INode: IMediator
    {
       string Identifier { get; set; }
    }
}
