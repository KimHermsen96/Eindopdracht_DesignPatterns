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

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "e":
                        Console.WriteLine("You choose to end the program");
                        return true;
                    case "c":
                        Console.WriteLine("You choose another circuit");
                        return false;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
            }
        }
    }
}
