using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose 1 for Leap Year Calculator and 2 for Guessing game");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
            {
                case 1:
                    leapyearcalculator();
                    break;
                case 2:
                    guessingGame();
                    break;

                default:
                    Console.WriteLine("Try selecting sth valid");
                    Console.ReadLine();
                    break;
            }
            }
           

        }

        static void leapyearcalculator()
        {
            Console.WriteLine("======== Leap year calculator ========");
            Console.WriteLine("\n");
            Console.WriteLine("======== What year is it? - -");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int yearIndex = currentYear % 4;
            if (yearIndex != 0)
            {
                Console.WriteLine($"This year ({currentYear}) is not a leap year");
                int nextLeapYear = currentYear + (4 - yearIndex);
                Console.WriteLine($"but, {nextLeapYear} would be tho. As well as");
                for (int i = 0; i < 10; i++)
                {
                    nextLeapYear += 4;
                    Console.WriteLine($"{nextLeapYear}");
                }


            }
            else
            {
                Console.WriteLine($"This year ({currentYear}) is a leap year.");
                Console.WriteLine($"infact");
                for (int i = 0; i < 10; i++)
                {
                    currentYear += 4;
                    Console.WriteLine($"{currentYear}");
                }
                Console.WriteLine($"would also be leap years");
            }

            Console.ReadLine();
        }

        static void guessingGame()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            int guess;
            int attempts = 0;

            do
            {
                attempts++;

                Console.Write("Guess a number between 1 and 10: ");
                string input = Console.ReadLine();

                // Check if the input is a valid number
                if (int.TryParse(input, out guess))
                {
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low. Try again.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! It took you {0} attempts.", attempts);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (guess != randomNumber);
}
    }
}
