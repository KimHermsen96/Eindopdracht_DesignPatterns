using System.Linq;
using CircuitLogic.controllers.Composite_pattern;
using CircuitLogic.controllers.State_pattern;
using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers
{
    public class CircuitValidator : IValidator
    {
        private Circuit Circuit { get; set; }
        public IState CurrentState { get; set; }

        public CircuitValidator(Circuit circuit)
        {
            Circuit = circuit;
        }

        public void SetState()
        {
            Circuit.State = new ValidCircuit();
            UnreachableNodes();
            Loop();
        }

        public void Loop()
        {
            foreach (var node in Circuit.AllNodes)
            {
                if (node.Value is Composite)
                {
                    var composite = (Composite) node.Value;
                    if (composite.CheckForLoop())
                    {
                        Circuit.State = new LoopCircuit();
                    }
                }
            }
        }

        //Visitor pattern
        private void UnreachableNodes()
        {
            ValidNodeVisitor validNodeVisitor = new ValidNodeVisitor();

            if (Circuit.AllNodes.Any(circuit => !circuit.Value.Accept(validNodeVisitor)))
            {
                Circuit.State = new UnreachableProbesCircuit(); 
            }
        }

    }
}
