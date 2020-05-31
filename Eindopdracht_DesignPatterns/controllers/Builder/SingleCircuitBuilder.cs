using Eindopdracht_DesignPatterns.controllers.Graphviz;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers.Composite_pattern;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class SingleCircuitBuilder : CircuitBuilder
    {
        private int FilePosition { get; set; } = 0;
        private string[] FileByLine { get; set; }
        private NodeFactory NodeFactory { get; set; }
        //public SingleCircuit Circuit { get; set; }
                
        private Regex MatchBefore { get; }
        private Regex MatchAfter { get; }

        public DotCompiler vis { get; set; }

        public Experiment2  a { get; set; }
        public Composite CompositeElement { get; set; }

        public SingleCircuitBuilder(string[] fileByLine) {
            FileByLine = fileByLine;

            MatchBefore = new Regex(@"\w+(?=:)");
            MatchAfter = new Regex(@"(?<=:).*\w+(?=;)");
            NodeFactory = NodeFactory.Instance;
            Circuit = new SingleCircuit();

            CompositeElement = new Composite();

            vis = new DotCompiler();
            a = new Experiment2();
        }


        public override void ConstructCircuit()
        {
            CreateNodes();
            CreateEdges();
            a.Render();
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
                        //Console.WriteLine(beforeColon + ": " + afterColon);
                        //voor visualisatie
                        //a.AddNode(createdNode.Identifier, createdNode.Identifier);
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

                    //get sourece node.
                    IComponent item = Circuit.AllNodes[beforeColon.ToString()];


                    if (beforeColon.Success && afterColon.Success)
                    {
                        string[] allEdges = afterColon.ToString().Split(',');
                        List<INode> Edges = new List<INode>();

                        foreach (var e in allEdges)
                        {
                            string edge = e.Trim();
                            //INode edgeNode = Circuit.AllNodes[edge.ToString()];
                            //Edges.Add(edgeNode);

                            //dit is code voor de visualisatie
                            //a.AddEdge(beforeColon.ToString(), edge);

                            IComponent edgeNode = Circuit.AllNodes[edge.ToString()];

                            Circuit.ComponentList.Add(edgeNode); 
                            item.AddComposite(edgeNode);
                            //Console.WriteLine(beforeColon + ": " + edge);
                        }

                       
                        //get source node 
                   

                        
                        //add source node and node targets 
                        //Circuit.CurrentCircuit.Add(item, Edges);
                    }
                }

            }
        }

        public void loopthro()
        {

        }

    }
}


