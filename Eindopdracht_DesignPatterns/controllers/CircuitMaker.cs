using Eindopdracht_DesignPatterns.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.controllers
{
    public class CircuitMaker
    {
        private string ChosenFile { get; set; }

        //Facade 
        public CircuitMaker(string _chosenFile)
        {
            ChosenFile = _chosenFile;
        }

        public Circuit MakeCircuit()
        {
            CircuitFileReader fileReader = new CircuitFileReader();
            string[] fileByLine = fileReader.Readfile(ChosenFile);
            Director director = new Director();
            SingleCircuitBuilder singleCircuitBuilder = new SingleCircuitBuilder(fileByLine);
            director.SetCircuitBuilder(singleCircuitBuilder);
            director.ConstructCircuit();
            return director.GetCircuit();
        }
    }
}
