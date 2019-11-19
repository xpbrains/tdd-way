using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz replacer");
            var fb = new FizzBuzzGame();
            for (int i = 1; i <= 100; i++)
            {
                Console.Write($@"{fb.Run(i)}  ");
            }
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
