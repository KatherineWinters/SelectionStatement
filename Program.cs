using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favoriteNumber = 100;

            Console.Write("Guess my favorite number: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < favoriteNumber)
            {
                Console.WriteLine("too low");
            }
            else if (guess > favoriteNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}