﻿using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CicruitIterator
    {

        private List<IComponent>  InitNodes { get; set; }
        public CicruitIterator(List<IComponent> _initNodes)
        {
            InitNodes = _initNodes;
        }

        public void Run()
        {
            foreach (var node in InitNodes)
            {
                var n = (Node)node;
                Console.WriteLine(n.Identifier);
                n.Run(n.Value);
            }
        }
    }
}
