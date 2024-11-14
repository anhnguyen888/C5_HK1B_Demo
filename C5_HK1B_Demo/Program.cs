using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace C5_HK1B_Demo
{
    internal class Program
    {
        static bool IsIn(int num, int[] array)
        {
            for (int i = 0; i < 3; i++)
            {
                if (num == array[i])
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to the Number Guessing Game!");
            //Console.WriteLine("I'm thinking of a number between 1 and 100.");
            //Console.WriteLine("You have 5 chances to guess the correct number.");
            //Console.WriteLine("Please select the difficulty level:");
            //Console.WriteLine("1.Easy(10 chances)");
            //Console.WriteLine("2.Medium(5 chances)");
            //Console.WriteLine("3.Hard(3 chances)");

            //int difficulty = 0;
            //while (difficulty < 1 || difficulty > 3)
            //{
            //    Console.Write("Enter your choice: ");
            //    difficulty = int.Parse(Console.ReadLine());
            //}

            //int chances = 0;

            //switch (difficulty)
            //{
            //    case 1:
            //        chances = 10;
            //        break;
            //    case 2:
            //        chances = 5;
            //        break;
            //    case 3:
            //        chances = 3;
            //        break;
            //}

            //Random random = new Random();
            //int number = random.Next(1, 101);

            //while (chances > 0)
            //{
            //    Console.WriteLine("You have " + chances + " chances left.");
            //    Console.Write("Enter your guess: ");
            //    int guess = int.Parse(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("Congratulations! You have guessed the correct number!");
            //        break;
            //    }
            //    else if (guess < number)
            //    {
            //        Console.WriteLine("The number is greater than your guess.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is less than your guess.");
            //    }

            //    chances--;
            //}
            //Console.WriteLine("The correct number is: " + number);
            //Console.WriteLine("Game Over!");
            //Console.ReadLine();

           
            int number = (new Random()).Next(100, 1000);
            int[] factors = new int[] { number / 100, (number / 10) % 10, number % 10 };

            while (true)
            {
                StringBuilder result = new StringBuilder();
                Console.WriteLine("Type in your guess: ");
                int guess = int.Parse(Console.ReadLine());
                int[] guessFactor = new int[] { guess / 100, (guess / 10) % 10, guess % 10 };

                for (int i = 0; i < 3; i++)
                {
                    if (guessFactor[i] == factors[i])
                        result.Append('+');
                    else
                    {
                        if (IsIn(guessFactor[i], factors))
                            result.Append('?');
                        else
                            result.Append('-');
                    }
                }

                System.Console.WriteLine(result.ToString());

                if (String.Compare(result.ToString(), "+++", true) == 0)
                    break;
            }

            System.Console.WriteLine("Congratulations!");

        }
    }
}
