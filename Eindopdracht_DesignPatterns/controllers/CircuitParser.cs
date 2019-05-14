using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitParser
    {
        public CircuitParser(string[] fileByLine)
        {
            for (int i = 0; i < fileByLine.Length; i++)
            {
             
            
                if (fileByLine[i].Equals("# Description of all the nodes"))
                {
                    CreateNodes(fileByLine, i);
                }
//
//                if (line.Equals("# Description of all the edges"))
//                {
//                }
            }
        }

        private void CreateNodes(string[] lines, int position)
        {
            string pattern = @".+?:";
            //match alles voor de dubbelepunt. 

            position = position + 2;
            while(!lines[position].Equals("#")){

                Match result = Regex.Match(lines[position], pattern);

                if (result.Success)
                {
                    Console.WriteLine("hier zit een : in " + result.Success);


                }

                position++;
            }
        }
    }
}