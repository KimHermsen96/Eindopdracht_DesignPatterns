using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;
using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.models
{
    public class SingleCircuit : Circuit, IIterableCollection
    {
       
        public override Dictionary<string, INode> AllNodes { get; set; }
        //public override Dictionary<INode, List<INode>> CurrentCircuit { get; set; }
        public override IState State { get; set; }
        public SingleCircuit()
        {
            AllNodes = new Dictionary<string, INode>();
            //CurrentCircuit = new Dictionary<INode, List<INode>>();
            State = null;
        }

        public void Run()
        {
            State.DoAction(this);
        }

        public override IIterator CreateIterator()
        {
            var iterator = new CicruitIterator(this);
            return iterator;
        }

    }
}
