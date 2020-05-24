using Eindopdracht_DesignPatterns.models;
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
        private int FilePosition { get; set; } = 0;
        private string[] FileByLine { get; set; }
        private NodeFactory NodeFactory { get; set; }
        public SingleCircuit Circuit { get; set; }

        private Regex MatchBefore { get; }
        private Regex MatchAfter { get; }


        public SingleCircuitBuilder(string[] fileByLine) {
            FileByLine = fileByLine;

            MatchBefore = new Regex(@"\w+(?=:)");
            MatchAfter = new Regex(@"(?<=:).*\w+(?=;)");
            NodeFactory = new NodeFactory();
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
                        INode createdNode = NodeFactory.CreateNode(beforeColon.ToString(), afterColon.ToString().Trim());
                        //add INode to list of all nodes. 
                        Circuit.AllNodes.Add(createdNode.Identifier, createdNode);
                        Console.WriteLine(beforeColon + ": " + afterColon);
                    }
                }

                if (FileByLine[i].Equals("# Description of all the edges")) {
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

                    if (beforeColon.Success && afterColon.Success)
                    {
                        string[] allEdges = afterColon.ToString().Split(',');
                        List<string> trimmedEdges = new List<string>();

                        foreach (var e in allEdges)
                        {
                            string edge = e.Trim();
                            trimmedEdges.Add(edge);
                            INode item = Circuit.AllNodes[beforeColon.ToString()];
                            item.TargetIdentifieers.Add(edge);
                            Console.WriteLine(beforeColon + ": " + edge);
                        }
                    }
                }

            }
        }

    }
}


