using Eindopdracht_DesignPatterns.models.interfaces;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.controllers.Composite_pattern
{
    public abstract class Composite : models.Nodes.Node
    {

        public Composite()
        {
            ComponentList = new List<IComponent>();
        }

        public void AddComposite(IComponent edge)
        {
            ComponentList.Add(edge);
        }
    }
}