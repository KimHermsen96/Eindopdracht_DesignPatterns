using DotBuilder.Statements;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Composite_pattern
{
    public abstract class Composite : models.Nodes.Node, IComponent
    {

        //public List<IComponent> ComponentList { get; set; }
        public int NumberOfInputs { get; set; }
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