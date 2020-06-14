using CircuitLogic.models.interfaces;
using CircuitLogic.models.Nodes;

namespace CircuitLogic.controllers
{
    public class ValidNodeVisitor : INodeVisitor
    {
        public bool Visit(And and)
        {
            return and.NumberOfInputNodes >= 2;
        }

        public bool Visit(Input input)
        {
            return true;
        }

        public bool Visit(Nand nand)
        {
           return nand.NumberOfInputNodes >= 2;
        }

        public bool Visit(Nor nor)
        {
            return nor.NumberOfInputNodes == 2;
        }

        public bool Visit(Not not)
        {
            return not.NumberOfInputNodes == 1;
        }

        public bool Visit(Or or)
        {
            return or.NumberOfInputNodes >= 2;
        }

        public bool Visit(Probe probe)
        {
            return true;
        }

        public bool Visit(Xor xor)
        {
            return xor.NumberOfInputNodes == 2;
        }
    }
}
