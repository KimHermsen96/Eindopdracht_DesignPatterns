﻿using System;
using System.Collections.Generic;
using CircuitLogic.controllers;
using CircuitLogic.models.interfaces;

namespace CircuitLogic.models.Nodes
{
    public abstract class Node : INodeStrategy , IComponent
    {
        public string Identifier { get; set; }
        public int Value { get; set; }
        public  bool Finished { get; set; } = false;

        public abstract bool Accept(ValidNodeVisitor validNodeVisitor);

        public int NumberOfInputNodes { get; set; }
        public List<int> SavedValues { get; set; }
        public abstract void CalculateOutput(int value);

      
        public Node()
        {
            SavedValues = new List<int>();
        }
        public void Run(int input)
        {
            if (Finished) return;
            CalculateOutput(input);
        }

        public void Clear()
        {
            NumberOfInputNodes = 0;
            SavedValues.Clear();
            Finished = false;
        }

       
    }
}
