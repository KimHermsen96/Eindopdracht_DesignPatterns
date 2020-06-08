using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public abstract class Node : IStrategy , IComponent
    {
        public List<IComponent> ComponentList { get; set; }
        public string Identifier { get; set; }
        public int Value { get; set; }
        public  bool Finished { get; set; } = false;
        public int NumberOfInputNodes { get; set; }
        public List<int> SavedValues { get; set; }
        public abstract void CalculateOutput(int value);
        public abstract bool ValidNode();
      
        public Node()
        {
            Console.WriteLine(Identifier);
            SavedValues = new List<int>();
        }
        public void Run(int input)
        {
            if (Finished) return;
            CalculateOutput(input);
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

        public void Clear()
        {
            NumberOfInputNodes = 0;
            SavedValues.Clear();
            Finished = false;
        }
    }
}
