using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitConsoleVisualizer
{
    public class EndCircuitView
    {
        public bool EndCircuit()
        {
            Console.WriteLine("Do you want to end the program or run another circuit?");
            Console.WriteLine("Choose e to end the program");
            Console.WriteLine("Choose c for another Circuit");
            var validInput = false;

            while (!validInput)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "e":
                        Console.WriteLine("You choose to end the program");
                        validInput = true;
                        return true;
                    case "c":
                        Console.WriteLine("You choose another circuit");
                        validInput = true;
                        return false;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
                //Console.Clear();
            }

            return true;
        }
    }
}
