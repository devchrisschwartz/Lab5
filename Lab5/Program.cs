using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the factorial calculator!");
            long userInput = ReadInput("Please enter a number from 1 to 20: ");
            Console.WriteLine($"The factorial of {userInput} is {FactorialCalculation(userInput)}");

            string userChoice;
            Console.Write("Would you like you contine? (y/n): ");
            userChoice = Console.ReadLine();
            while (userChoice.ToLower() == "y")
            {
                userInput = ReadInput("Please enter another number from 1 to 20: ");
                Console.WriteLine($"The factorial of {userInput} is {FactorialCalculation(userInput)}");
                Console.Write("Would you like you contine? (y/n): ");
                userChoice = Console.ReadLine();

            }

        }

        public static bool WithinRange(long userInput)
        {
            if (userInput <1 || userInput > 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static long FactorialCalculation(long number)
        {
            long result = 1;
            for (long i = 1; i <= number; i++)
            {
                result = i * result;
            }
            return result;
        }

        public static long ReadInput(string message)
        {
            Console.Write(message);
            long input = long.Parse(Console.ReadLine());
            while (WithinRange(input) == false)
            {
                Console.WriteLine("Sorry, the number you entered is not within the valid range for this calculator.");
                Console.Write("Please enter a number between 1 and 20: ");
                input = long.Parse(Console.ReadLine());
            }
            return input;
        }
    }
}
