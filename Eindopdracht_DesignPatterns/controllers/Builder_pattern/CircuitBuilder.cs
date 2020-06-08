using Eindopdracht_DesignPatterns.models;

namespace Eindopdracht_DesignPatterns.controllers.Builder_pattern
{
    public abstract class CircuitBuilder
    {
        public Circuit Circuit;

        public Circuit GetCircuit()
        {
            return Circuit;
        }
      
        protected abstract void CreateNodes();
        protected abstract void CreateEdges();

        //Template method
        public void ConstructCircuit()
        {
            CreateNodes();
            CreateEdges();
        }
    }
}