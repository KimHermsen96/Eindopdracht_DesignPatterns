using CircuitLogic.models.Nodes;
using System;

namespace CircuitConsoleVisualizer
{
    public class ChooseInputValues
    {
        public bool UseDefault()
        {
            Console.WriteLine("Do you want to use default input?");
            Console.WriteLine("Enter y for yes");
            Console.WriteLine("Enter n for no");

            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        Console.WriteLine("You choose yes");
                        return true;
                    case "n":
                        Console.WriteLine("You choose no");
                        return false;
                    default:
                        Console.WriteLine("invalid input try again");
                        break;
                }
            }
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
