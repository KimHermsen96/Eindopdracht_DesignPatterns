using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.State
{
    public class Loop : IState
    {
        public void DoAction(Circuit circuit)
        {
            Console.WriteLine("Invalid Circuit due to loop"); 
        }
    }
}
