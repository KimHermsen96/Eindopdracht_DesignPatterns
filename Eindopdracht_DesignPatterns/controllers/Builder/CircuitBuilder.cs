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

        public Dictionary<string, INode> Circuit;

        public Dictionary<string, INode> GetCircuit()
        {
            return Circuit;
        }

        public abstract int CreateNodes(string[] lines, int position);
        public abstract int CreateEdges(string[] lines, int position);


    }
}