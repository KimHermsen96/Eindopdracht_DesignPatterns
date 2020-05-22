using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class SingleCircuitBuilder : CircuitBuilder
    {

        private string matchBefore = @"\w+(?=:)";
        private string matchAfter = @"(?<=:).*\w+(?=;)";

        public override int CreateEdges(string[] lines, int position)
        {
            for (int i = position; i < lines.Length; i++)
            {
                Match beforeColon = Regex.Match(lines[i], matchBefore);
                Match afterColon = Regex.Match(lines[i], matchAfter);

                if (beforeColon.Success && afterColon.Success)
                {
                    string[] allEdges = afterColon.ToString().Split(',');
                    List<string> trimmedEdges = new List<string>();

                    foreach (var e in allEdges)
                    {
                        string edge = e.Trim();
                        trimmedEdges.Add(edge);

                        //mediator.AddEdge(beforeColon.ToString(), edge);

                        INode item = Circuit[beforeColon.ToString()];
                        item.TargetIdentifieers.Add(edge);
                        //                        Console.WriteLine(beforeColon + ": " + edge);
                    }
                }
            }
            return lines.Length;
        }

        public override int CreateNodes(string[] lines, int position)
        {
            throw new NotImplementedException();
        }

        //    public void AddEdge(string nodeIdentifier, string edgeIdentifier)
        //    {
        //        INode item = allElements[nodeIdentifier];
        //        item.TargetIdentifieers.Add(edgeIdentifier);
        //    }

        //    public override int CreateNodes(string[] lines, int position)
        //    {
        //        NodeFactory nodeFactory = new NodeFactory();
        //        while (!lines[position].Equals(""))
        //        {

        //            Match beforeColon = Regex.Match(lines[position], matchBefore);
        //            Match afterColon = Regex.Match(lines[position], matchAfter);

        //            if (beforeColon.Success && afterColon.Success)
        //            {
        //                INode createdNode = nodeFactory.CreateCircuit(beforeColon.ToString(), afterColon.ToString().Trim());
        //                Console.WriteLine(beforeColon + ": " + afterColon);
        //                mediator.AddElement(createdNode, createdNode.Identifier);


        //            }
        //            position++;
        //        }
        //        return position;
        //    }
        //}
    }
}
