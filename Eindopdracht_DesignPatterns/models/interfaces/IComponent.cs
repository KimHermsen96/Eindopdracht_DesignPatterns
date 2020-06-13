using Eindopdracht_DesignPatterns.controllers;

namespace Eindopdracht_DesignPatterns.models.interfaces
{
    public interface IComponent
    {
        bool Accept(ValidNodeVisitor validNodeVisitor);
        int NumberOfInputNodes { get; set; }
    }
}
