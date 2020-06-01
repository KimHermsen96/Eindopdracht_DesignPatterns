using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.controllers.State;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitValidator
    {
        private Circuit Circuit { get; set; }
        public CircuitValidator(Circuit circuit)
        {
            Circuit = circuit;
        }

        public IState CheckState()
        {
            //if (UnreachableProbes()) return new UnreachableProbes();
            if (Loop()) return new Loop();
            return new ValidCircuit();
        }

       public bool Loop()
        {


            return false; 
        }


        //private bool UnreachableProbes()
        //{
        //    foreach (var element in Circuit.AllNodes)
        //    {
        //        /// if false.. returned false als het element niet connected is. 
        //        if (!ElementIsConnected(element.Key, element.Value)) return true;
        //    }
        //    return false;
        //}

        //public bool ElementIsConnected(string key, INode value)
        //{
        //    foreach (var edge in Circuit.CurrentCircuit)
        //    {
        //        //hier check ik of de huidige nodes wel in de lijst voorkomen. 
        //        if (edge.Key.Identifier == key || value is Probe) return true;
        //    }
        //    //als niet beide keys in de lijst voorkomen betekend dit dat de er een node niet verbonden is. 
        //    return false;
        //}


    }
}
