using CircuitLogic.models;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.controllers.State_pattern
{
    public class ValidCircuit : IState
    {
        public void DoAction(Circuit circuit)
        {
            foreach (var node in circuit.Firsts)
            {
                node.Run(node.Value);
            }
        }
    }
}
