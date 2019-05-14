using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            bool NoChosenFile = true;
            string chosenFile = "";

            while (NoChosenFile)
            {
                Console.WriteLine("Choose a circuit (1, 2, 3, 4)");
                chosenFile = ChooseFile();

                if (chosenFile != "No file selected") NoChosenFile = false;
            }

            Console.WriteLine("You chose:" + chosenFile);
            PrintFile(chosenFile);
        }

        private static void PrintFile(string file)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                @"data\" + file);

            string[] files = File.ReadAllLines(path);
            foreach (var f in files) Console.WriteLine(f);

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
                        return file = "Circuit2_InfiniteLoop.txt";
                    case 5:
                        return file = "Circuit2_NotConnected.txt";
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