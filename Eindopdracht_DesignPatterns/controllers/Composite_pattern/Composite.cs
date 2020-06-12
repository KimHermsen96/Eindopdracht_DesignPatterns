using System;
using Eindopdracht_DesignPatterns.models.interfaces;
using System.Collections.Generic;
using System.Linq;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.controllers.Composite_pattern
{
    public abstract class Composite : Node
    {
        public List<IComponent> ComponentList { get; set; }

        protected Composite()
        {
            ComponentList = new List<IComponent>();
        }

        public void AddComposite(IComponent edge)
        {
            ComponentList.Add(edge);
        }

        public void Continue()
        {
            foreach (var node in ComponentList)
            {
                var n = (Node)node;
                Console.WriteLine(n.Identifier);
                n.Run(Value);
            }
        }

        public bool Loop()
        {
            return ComponentList.Any(el => el.GetType() == typeof(Probe) && ComponentList.Count > 1);
        }
    }
}