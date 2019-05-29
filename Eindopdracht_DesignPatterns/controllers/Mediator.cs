using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Mediator : IMediator 
    {
        private  Dictionary<string, INode> allElements;

        private int startValue { get; set; }

        public Mediator()
        {
            allElements= new Dictionary<string, INode>();
        }

        public void AddElement(INode node, string identifier)
        {
            allElements.Add(identifier, node);
        }

        public void AddEdge(string nodeIdentifier, string edgeIdentifier)
        {
            INode item = allElements[nodeIdentifier];
            item.TargetIdentifieers.Add(edgeIdentifier);

            Console.WriteLine("iten:" + item + "target: " + edgeIdentifier);
            Console.ReadKey();
        }

        public void Notify(INode sender, int message)
        {
            throw new NotImplementedException();
        }
    }
}
