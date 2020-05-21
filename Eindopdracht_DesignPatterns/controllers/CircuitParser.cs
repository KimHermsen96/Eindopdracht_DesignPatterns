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
    public class CircuitParser
    {
        private string matchBefore = @"\w+(?=:)";
        private string matchAfter = @"(?<=:).*\w+(?=;)";

        private Mediator mediator;
        NodeFactory nodeFactory = new NodeFactory();


        public CircuitParser(string[] fileByLine)
        {

            mediator = Mediator.instance;

            for (int i = 0; i < fileByLine.Length; i++)
            {
                var newPostion = i;

                if (fileByLine[i].Equals("# Description of all the nodes")) newPostion = CreateNodes(fileByLine, i);
                i = newPostion;
                
                if (fileByLine[i].Equals("# Description of all the edges")) newPostion = CreateEdges(fileByLine, i);
                i = newPostion;
            }
        }

        private int CreateEdges(string[] lines, int position)
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

                        mediator.AddEdge(beforeColon.ToString(), edge);                       
//                        Console.WriteLine(beforeColon + ": " + edge);
                    }
                }
            }
            return lines.Length; 
        }

        private int CreateNodes(string[] lines, int position)
        {

            NodeFactory nodeFactory = new NodeFactory();
            while(!lines[position].Equals("")){

                Match beforeColon = Regex.Match(lines[position], matchBefore);
                Match afterColon = Regex.Match(lines[position], matchAfter);

                if (beforeColon.Success && afterColon.Success)
                {
                  INode createdNode =  nodeFactory.CreateCircuit(beforeColon.ToString(), afterColon.ToString().Trim());
                  Console.WriteLine(beforeColon + ": " + afterColon);
                  mediator.AddElement(createdNode, createdNode.Identifier);


                }
                position++;
            }
            return position;
        }
    }
}