using System;

namespace NumberGuesser
{
    class Program
    {
        static void DisplayGreeting()
        {

            Console.WriteLine("Welcome to Number Guesser");
            Console.WriteLine("");
            Console.WriteLine("Rules of the Game");
            Console.WriteLine("1. Think of a number between 1 - 1024");
            Console.WriteLine("2. I will guess the number");
            Console.WriteLine("3. You will indicate whether my guess is Correct, Too High or Too Low");
            Console.WriteLine("Lets begin!");

        }

        static void Main(string[] args)
        {
            DisplayGreeting();


        }


    }
}

