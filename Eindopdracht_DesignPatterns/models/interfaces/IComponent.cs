using CircuitLogic.controllers;

namespace CircuitLogic.models.interfaces
{
    public interface IComponent
    {
        bool Accept(ValidNodeVisitor validNodeVisitor);
        int NumberOfInputNodes { get; set; }
    }
}
