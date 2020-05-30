using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface INode : IStrategy , IComponent
    {
        string Identifier { get; set; }
        int Value { get; set; }
        //void CalculateOutput(int value);

    }
}
