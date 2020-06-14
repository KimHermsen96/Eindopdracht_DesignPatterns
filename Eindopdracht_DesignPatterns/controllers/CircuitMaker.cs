using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CircuitLogic.controllers.Builder_pattern;
using CircuitLogic.models;
using Eindopdracht_DesignPatterns.controllers.Strategy_pattern;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace CircuitLogic.controllers
{
    public class CircuitMaker
    {
        private string ChosenFile { get; set; }
        private IFileReaderStrategy CurrentStrategy { get; set; }

        //Facade 
        public CircuitMaker(string chosenFile)
        {
            ChosenFile = chosenFile;
        }

        public Circuit MakeCircuit()
        {

            ChooseFileReader();
            string[] fileByLine = CurrentStrategy.Readfile(ChosenFile);

            Director director = new Director();
            SingleCircuitBuilder singleCircuitBuilder = new SingleCircuitBuilder(fileByLine, ChosenFile);
            director.SetCircuitBuilder(singleCircuitBuilder);
            director.ConstructCircuit();
            return director.GetCircuit();
        }


        private void ChooseFileReader()
        {
            var MatchJson = new Regex(@".json$");
            var MatchTxt = new Regex(@".txt$");

            Match json = MatchJson.Match(ChosenFile);
            Match txt = MatchTxt.Match(ChosenFile);
            
            if (json.Success)
            {
                CurrentStrategy = new JsonFileReaderStrategy();
            }
            else if(txt.Success)
            {
                CurrentStrategy = new TextFileReaderStrategy();
            }
            
        }
    }
}
