﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.models.Nodes
{
    public class Input : INode
    {
        public void Notify(INode sender, int message)
        {
            throw new NotImplementedException();
        }

        public string Descriptor { get; set; }
        public List<string> TargetIdentifieers { get; set; }
    }
}
