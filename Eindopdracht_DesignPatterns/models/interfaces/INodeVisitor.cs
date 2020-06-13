using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface INodeVisitor
    {
        bool Visit(And and);
        bool Visit(Input and);
        bool Visit(Nand and);
        bool Visit(Nor and);
        bool Visit(Not and);
        bool Visit(Or and);
        bool Visit(Probe and);
        bool Visit(Xor and);
    }
}
