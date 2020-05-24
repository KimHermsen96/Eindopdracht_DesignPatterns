using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Eindopdracht_DesignPatterns.controllers;
using Eindopdracht_DesignPatterns.models;
using Eindopdracht_DesignPatterns.models.interfaces;

namespace Eindopdracht_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Mediator mediator =  Mediator.instance; 

            bool noChosenFile = true;
            string chosenFile = "";

            while (noChosenFile)
            {
                Console.WriteLine("Choose a circuit (1, 2, 3, 4)");
                chosenFile = ChooseFile();

                if (chosenFile != "No file selected") noChosenFile = false;
            }

            Console.WriteLine("You chose:" + chosenFile);

            FileReader fileReader = new FileReader();
            string[] fileByLine = fileReader.Readfile(chosenFile);

            Director director = new Director();
            SingleCircuitBuilder singleCircuitBuilder = new SingleCircuitBuilder(fileByLine);
            director.SetCircuitBuilder(singleCircuitBuilder);
            director.ConstructCircuit();
            Circuit singlecir = director.GetCircuit();


            CircuitValidator validator = new CircuitValidator(singlecir);


            singlecir.State = validator.CheckState();

            singlecir.State.DoAction(singlecir);
            //mediator.Execute();

            Console.ReadKey();
        }

        private static string ChooseFile()
        {
            string file;
            var choice = Console.ReadLine();
            try
            {
                int i = System.Convert.ToInt32(choice);
                switch (i)
                {
                    case 1:
                        return file = "Circuit1_FullAdder.txt";
                    case 2:
                        return file = "Circuit2_Decoder.txt";
                    case 3:
                        return file = "Circuit3_Encoder.txt";
                    case 4:
                        return file = "Circuit4_InfiniteLoop.txt";
                    case 5:
                        return file = "Circuit5_NotConnected.txt";
                    default:
                        return file = "Circuit1_FullAdder.txt";
                }
            }
            catch (FormatException)
            {
                return "No file selected";
            }
        }
    }
}