using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input '1' to stop the program");
                string input = Console.ReadLine();
                Console.Clear();
                if (input == "1")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input numbers in this format 'x,y,z' to calculate");
                    string number = Console.ReadLine();
                    string result = StringCalculator.Add(number);
                    Console.WriteLine($"The result is {result}");
                }
            }
        }

    }
}
