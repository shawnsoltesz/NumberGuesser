using System;

namespace NumberGuesser

{
    class Program
    {
        static void DisplayGreeting()
        {

            Console.WriteLine("Welcome to Number Guesser\n");
            Console.WriteLine("Rules of the Game");
            Console.WriteLine("1. Think of a number between 1 - 1024");
            Console.WriteLine("2. The computer will guess the number");
            Console.WriteLine("3. You will indicate whether my guess is 1. Correct, 2. High or 3. Low");
            Console.WriteLine("We'll continue until I get it correct.\n");
            Console.WriteLine("Lets play!\n");
        }

        static void Main(string[] args)
        {
            DisplayGreeting();

            int Low = 1;
            int High = 1024;
            int DifferenceOfRange = High - Low;
            int Midpoint = DifferenceOfRange / 2;
            int MidValue = Low + Midpoint;
            //int Count = 1;
            bool Number = true;


            while (Low <= High && Number)
            {
                DifferenceOfRange = High - Low;
                Midpoint = DifferenceOfRange / 2;
                MidValue = Low + Midpoint;

                Console.WriteLine("Is your number: {0}?", MidValue);
                Console.WriteLine(" 1: That is my number \n 2: No my number is greater \n 3: No my number is lower ");
                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    Console.WriteLine("Hot damn! The computer won! Woot Woot!!");
                    Number = false;
                }

                if (Low < High && userChoice == 2)
                {
                    Low = MidValue + 1;
                    //Console.WriteLine("Your number is {0}", MidValue);
                }
                else if (Low < High && userChoice == 3)
                {
                    High = MidValue - 1;
                    //Console.WriteLine("Your number is {0}", MidValue);
                }

            }



            {

            }



        }


    }
}

