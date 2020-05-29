using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht_DesignPatterns.view
{
    public class InputView
    {
        public InputView()
        {
        }

        public bool UseUserInput()
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
                        break;
                    case "n":
                        Console.WriteLine("You choose no");
                        validInput = true;
                        break;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
            }
            return true;
        }
        public int AskInput(string _nodeName)
        {
            var validInput = false;
            Console.WriteLine("Choose the input for " + _nodeName);
            var input = Console.ReadLine();
            int number = 0; 
            switch (input)
            {
                case "0":
                    Console.WriteLine("You choose 0");
                    number = 0; 
                    validInput = true;
                    break;
                case "1":
                    Console.WriteLine("You choose 1");
                    number = 1;
                    validInput = true;
                    break;
                default:
                    Console.WriteLine("invalid input try again");
                    break;
            }
            return number;
        }
    }
}
