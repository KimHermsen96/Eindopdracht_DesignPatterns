using DotBuilder.Statements;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public abstract class Node : IStrategy , IComponent
    {
        public List<IComponent> ComponentList { get; set; }
        public string Identifier { get; set; }
        public int Value { get; set; }
        public  bool Finished { get; set; } = false;
        public int NumberOfInputNodes { get; set; }

        public abstract void CalculateOutput(int value);
        public abstract bool ValidNode();
      
        public Node()
        {
            Console.WriteLine(Identifier);
        }
        public void Run(int input)
        {
            if (Finished) return;
            CalculateOutput(input);
        }

        protected void Continue()
        {
            foreach (var node in ComponentList)
            {
                var n = (Node)node;
                Console.WriteLine(n.Identifier);
                n.Run(Value);
            }
        }
    }
}
