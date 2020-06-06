using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers.State
{
    public class UnreachableProbes : IState
    {
        public void DoAction(CircuitTemplate circuit)
        {

            Console.WriteLine("Invalid Circuit due unreachable probes ");
        }
    }
}
