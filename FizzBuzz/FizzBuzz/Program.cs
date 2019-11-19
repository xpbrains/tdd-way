using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz replacer");
            var game = new FizzBuzzGame();
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($@"{game.Run(i)}  ");
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
