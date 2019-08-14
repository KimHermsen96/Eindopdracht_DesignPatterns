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

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitParser
    {
        public Dictionary<string, string> Nodes { get; set; }
        public Dictionary<string, List<string>> Edges { get; set; }

        public CircuitParser(string[] fileByLine)
        {
            Nodes = new Dictionary<string, string>();
            Edges = new Dictionary<string, List<string>>();

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
                string matchBefore = @"\w+(?=:)";
                string matchAfter = @"(?<=:).*\w+(?=;)";

                Match beforeColon = Regex.Match(lines[i], matchBefore);
                Match afterColon = Regex.Match(lines[i], matchAfter);

                if (beforeColon.Success && afterColon.Success)
                {
                    string[] allEdges = afterColon.ToString().Split(',');
                    List<string> trimmedEdges = new List<string>();

                    Edges.Add(beforeColon.ToString(), new List<string>());

                    foreach (var e in allEdges)
                    {
                        string edge = e.Trim();
                        trimmedEdges.Add(edge);
                        List<string> targetList = Edges[beforeColon.ToString()];
                        targetList.Add(edge);
                    }
                }
            }

            return lines.Length;
        }

        private int CreateNodes(string[] lines, int position)
        {
            while (!lines[position].Equals(""))
            {
                string matchBefore = @"\w+(?=:)";
                string matchAfter = @"(?<=:).*\w+(?=;)";

                Match beforeColon = Regex.Match(lines[position], matchBefore);
                Match afterColon = Regex.Match(lines[position], matchAfter);

                if (beforeColon.Success && afterColon.Success)
                {
                    Nodes.Add(beforeColon.ToString(), afterColon.ToString().Trim());
                }

                position++;
            }

            return position;
        }
    }
}