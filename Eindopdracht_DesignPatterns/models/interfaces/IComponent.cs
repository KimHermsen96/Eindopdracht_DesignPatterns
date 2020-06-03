using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface IComponent
    {
        List<IComponent> ComponentList { get; set; }
        int NumberOfInputNodes { get; set; }
    }
}
