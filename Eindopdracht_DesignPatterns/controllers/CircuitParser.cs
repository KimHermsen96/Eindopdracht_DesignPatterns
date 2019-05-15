using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitParser
    {
        private string matchBefore = @"\w+(?=:)";
        private string matchAfter = @"(?<=:).*\w+(?=;)";

        public CircuitParser(string[] fileByLine)
        {
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
                    foreach (var e in allEdges)
                    {
                        string edge = e.Trim();
                        Console.WriteLine(beforeColon + ": " + edge);   
                    }
                }
            }
            return lines.Length; 
        }

        private int CreateNodes(string[] lines, int position)
        {
            while(!lines[position].Equals("")){

                Match beforeColon = Regex.Match(lines[position], matchBefore);
                Match afterColon = Regex.Match(lines[position], matchAfter);

                if (beforeColon.Success && afterColon.Success)
                {
                    Console.WriteLine(beforeColon + ": " + afterColon);
                }
                position++;
            }
            return position;
        }
    }
}