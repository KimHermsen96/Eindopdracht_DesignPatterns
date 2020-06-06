using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitConsoleVisualizer
{
    public class ChooseFileView
    {
        public string ChosenFile { get; set; }
        public ChooseFileView()
        {
            bool noChosenFile = true;

            while (noChosenFile)
            {
                Console.WriteLine("Choose a circuit (1, 2, 3, 4)");
                ChosenFile = ChooseFile();

                if (ChosenFile != "No file selected") noChosenFile = false;
            }
            Console.Clear();
            Console.WriteLine("You chose:" + ChosenFile);
        }

        private static string ChooseFile()
        {
            var choice = Console.ReadLine();
            try
            {
                int i = System.Convert.ToInt32(choice);
                switch (i)
                {
                    case 1:
                        return "Circuit1_FullAdder.txt";
                    case 2:
                        return "Circuit2_Decoder.txt";
                    case 3:
                        return "Circuit3_Encoder.txt";
                    case 4:
                        return "Circuit4_InfiniteLoop.txt";
                    case 5:
                        return "Circuit5_NotConnected.txt";
                    default:
                        return "Circuit1_FullAdder.txt";
                }
            }
            catch (FormatException)
            {
                return "No file selected";
            }
        }


    }
}
