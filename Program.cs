using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            string input = "Y";

            while (input == "Y")
            {

                Console.WriteLine("Enter Length");
                var userInput1 = Console.ReadLine();
                decimal userInput1dec = Convert.ToDecimal(userInput1);

                Console.WriteLine("Enter Width");
                var userInput2 = Console.ReadLine();
                decimal userInput2dec = Convert.ToDecimal(userInput2);

                var area = userInput1dec * userInput2dec;
                Console.WriteLine("Area: " + area);

                var perimeter = userInput1dec + userInput1dec + userInput2dec + userInput2dec;
                Console.WriteLine("Perimeter: " + perimeter);

                Console.WriteLine("Continue? Y/N");
                input = Console.ReadLine();
            }
        }
    }
}
