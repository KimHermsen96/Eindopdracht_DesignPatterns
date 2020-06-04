using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;
using Eindopdracht_DesignPatterns.models.Nodes;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class SingleCircuitBuilder : CircuitBuilder
    {
        private int FilePosition { get; set; } = 0;
        private string[] FileByLine { get; set; }
        private NodeFactory NodeFactory { get; set; }

        private Regex MatchBefore { get; }
        private Regex MatchAfter { get; }

        public SingleCircuitBuilder(string[] fileByLine)
        {
            FileByLine = fileByLine;

            MatchBefore = new Regex(@"\w+(?=:)");
            MatchAfter = new Regex(@"(?<=:).*\w+(?=;)");
            NodeFactory = NodeFactory.Instance;
            Circuit = new SingleCircuit();
        }

        public override void ConstructCircuit()
        {
            CreateNodes();
            CreateEdges();
        }

        public override void CreateNodes()
        {
            for (int i = 0; i < FileByLine.Length; i++)
            {
                var hashtagReg = new Regex(@"^#.*");
                Match startsWithHashtag = hashtagReg.Match(FileByLine[i]);

                if (!startsWithHashtag.Success)
                {
                    Match beforeColon = MatchBefore.Match(FileByLine[i]);
                    Match afterColon = MatchAfter.Match(FileByLine[i]);

                    if (beforeColon.Success && afterColon.Success)
                    {
                        Node createdNode = NodeFactory.CreateNode(beforeColon.ToString(), afterColon.ToString().Trim());
                        //add INode to list of all nodes. 
                        Circuit.AllNodes.Add(createdNode.Identifier, createdNode);
                        //voor visualisatie
                        //a.AddNode(createdNode.Identifier, createdNode.Identifier);
                        if (createdNode.GetType() == typeof(Input)) Circuit.Firsts.Add(createdNode);
                    }
                }

                if (FileByLine[i].Equals("# Description of all the edges"))
                {
                    FilePosition = i;
                    break;
                }
            }
        }


        public override void CreateEdges()
        {

            Console.WriteLine(" ----------  nu de edges -------");
            for (int i = FilePosition; i < FileByLine.Length; i++)
            {
                var regex = new Regex(@"\d+");
                Match containsNodes = regex.Match(FileByLine[i]);

                if (containsNodes.Success)
                {
                    Match beforeColon = MatchBefore.Match(FileByLine[i]);
                    Match afterColon = MatchAfter.Match(FileByLine[i]);

                    //get sourece node.
                    IComponent item = Circuit.AllNodes[beforeColon.ToString()];

                    if (beforeColon.Success && afterColon.Success)
                    {
                        string[] allEdges = afterColon.ToString().Split(',');
                        List<Node> Edges = new List<Node>();

                        foreach (var e in allEdges)
                        {
                            string edge = e.Trim();
                            //dit is code voor de visualisatie
                            //a.AddEdge(beforeColon.ToString(), edge);

                            IComponent edgeNode = Circuit.AllNodes[edge.ToString()];
                            edgeNode.NumberOfInputNodes++;

                            var composite = (Composite)item;
                            composite.AddComposite(edgeNode);
                        }
                    }
                }
            }
        }
    }
}


