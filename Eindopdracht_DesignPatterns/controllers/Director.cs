using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class Director
    {
        private string chosenFile;

        public Director(string chosenFile)
        {
            this.chosenFile = chosenFile;
        }
   
        public void ReadFile()
        {
            FileReader fileReader = new FileReader();
            string[] fileByLine = fileReader.Readfile(chosenFile);

            CircuitParser parser = new CircuitParser(fileByLine);
            CircuitBuilder builder = new CircuitBuilder();

            builder.CreateNodes(parser.Nodes);
            builder.CreateEdges(parser.Edges);
            builder.ExecuteCircuit();
            

//
//            if (Mediator.CheckIfValid())
//            {
//                Mediator.Execute();
//            }
//            else
//            {
//                Console.WriteLine("Circuit is not valid");
//            }

        }

    }
}
