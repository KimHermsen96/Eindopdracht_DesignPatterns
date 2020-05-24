using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public abstract class CircuitBuilder
    {

        public Circuit Circuit;

        public Circuit GetCircuit()
        {
            return Circuit;
        }

        public abstract void CreateNodes();
        public abstract void CreateEdges();
        public abstract void ConstructCircuit();


    }
}