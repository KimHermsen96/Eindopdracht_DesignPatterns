using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircuitLogic.controllers.Builder_pattern;
using CircuitLogic.models;

namespace CircuitLogic.controllers
{
    public class CircuitMaker
    {
        private string ChosenFile { get; set; }

        //Facade 
        public CircuitMaker(string chosenFile)
        {
            ChosenFile = chosenFile;
        }

        public Circuit MakeCircuit()
        {
            CircuitFileReader fileReader = new CircuitFileReader();
            string[] fileByLine = fileReader.Readfile(ChosenFile);

            Director director = new Director();
            SingleCircuitBuilder singleCircuitBuilder = new SingleCircuitBuilder(fileByLine, ChosenFile);
            director.SetCircuitBuilder(singleCircuitBuilder);
            director.ConstructCircuit();
            return director.GetCircuit();
        }
    }
}
