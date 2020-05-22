using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class FileParser
    {
     
        private int FilePosition { get; set; } = 0; 
        private string[] FileByLine { get; set; }
        private NodeFactory NodeFactory { get; set; }

        private SingleCircuit Circuit { get; set; }

        private Regex MatchBefore { get; }
        private Regex MatchAfter { get; }

        public FileParser(string[] fileByLine)
        {
            FileByLine = fileByLine;

            MatchBefore = new Regex(@"\w+(?=:)");
            MatchAfter = new Regex(@"(?<=:).*\w+(?=;)");
            NodeFactory = new NodeFactory();
            Circuit = new SingleCircuit();
        }

        //ik wil dat er een lijst van nodes uit komt die gecreerd moet worden. 
        public void NodeReader()
        {
            for (int i = 0; i < FileByLine.Length; i++)
            {
                var regex = new Regex(@"\d+");
                Match containsNodes = regex.Match(FileByLine[i]);

                if (containsNodes.Success)
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
                if (FileByLine[i].Equals("# Description of all the edges")) break; 
            }
        }


        //public void CircuitReader()
        //{
        //    for (int i = FilePosition; i < FileByLine.Length; i++)
        //    {
        //        FilePosition = i;

        //        if (FileByLine[i].Equals("# Description of all the edges")) FilePosition = CreateEdges(fileByLine, i);
        //        i = FilePosition;
        //    }


        //}


        //private int CreateNodes(string[] lines, int position)
        //{

        //    while (!lines[position].Equals(""))
        //    {

        //        Match beforeColon = Regex.Match(lines[position], matchBefore);
        //        Match afterColon = Regex.Match(lines[position], matchAfter);

        //        if (beforeColon.Success && afterColon.Success)
        //        {
        //            INode createdNode = NodeFactory.CreateCircuit(beforeColon.ToString(), afterColon.ToString().Trim());
        //            Console.WriteLine(beforeColon + ": " + afterColon);
        //            mediator.AddElement(createdNode, createdNode.Identifier);


        //        }
        //        position++;
        //    }
        //    return position;
        //}


        //private int CreateEdges(string[] lines, int position)
        //{


        //    for (int i = position; i < lines.Length; i++)
        //    {
        //        Match beforeColon = Regex.Match(lines[i], matchBefore);
        //        Match afterColon = Regex.Match(lines[i], matchAfter);

        //        if (beforeColon.Success && afterColon.Success)
        //        {
        //            string[] allEdges = afterColon.ToString().Split(',');
        //            List<string> trimmedEdges = new List<string>();

        //            foreach (var e in allEdges)
        //            {
        //                string edge = e.Trim();
        //                trimmedEdges.Add(edge);

        //                mediator.AddEdge(beforeColon.ToString(), edge);
        //                //                        Console.WriteLine(beforeColon + ": " + edge);
        //            }
        //        }
        //    }
        //    return lines.Length;
        //}


    }
}