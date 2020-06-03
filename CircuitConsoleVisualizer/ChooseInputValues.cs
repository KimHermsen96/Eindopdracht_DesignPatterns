using Eindopdracht_DesignPatterns.models.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircuitConsoleVisualizer
{
    public class ChooseInputValues
    {
        public bool UseDefault()
        {
            var validInput = false;
            Console.WriteLine("Do you want to use default input?");
            Console.WriteLine("Enter y for yes");
            Console.WriteLine("Enter n for no");

            while (!validInput)
            {

                var input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        Console.WriteLine("You choose yes");
                        validInput = true;
                        return true;
                    case "n":
                        Console.WriteLine("You choose no");
                        validInput = true;
                        return false;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
            }
            return true;
        }
        public void SetInput(Node node)
        {
            var validInput = false;
            while (!validInput)
            {
                Console.WriteLine("Choose the input for " + node.Identifier);
                var input = Console.ReadLine();
                
                switch (input)
                {
                    case "0":
                        Console.WriteLine("You choose 0");
                        node.Value = 0;
                        validInput = true;
                        break;
                    case "1":
                        Console.WriteLine("You choose 1");
                        node.Value = 1;
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
            }
        }
    }
}
