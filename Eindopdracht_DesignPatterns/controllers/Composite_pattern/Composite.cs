using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.Composite_pattern
{
    public class Composite : IComponent
    {

        public List<IComponent> ComponentList { get; set; }
   
        public void AddComposite(IComponent edge)
        {
            ComponentList.Add(edge);
        }

    }
}
