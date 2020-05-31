using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CicruitIterator : IIterator
    {

        public  Composite Composite{ get; set; }

        public CicruitIterator(Composite _composite)
        {
            Composite = _composite;
            GetNext();
        }
        public void GetNext()
        {
            foreach(var edge in Composite.ComponentList)
            {
                Console.WriteLine(edge);

                var x = (INode)edge;
                Console.WriteLine(x.Identifier );
            }
        }
    }
}
