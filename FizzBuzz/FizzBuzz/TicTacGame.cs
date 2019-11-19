using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class OddEvenGame : NiceGame
    {
        public OddEvenGame() : base(CreateRules())
        {
            Console.WriteLine($"Game  {nameof(OddEvenGame)} started.");
        }

        private static GameRules CreateRules()
        {
            return new GameRules
            {
                { EachOdd,  "Tic" },
                { EachEven, "Tac" }
            };
        }

        private static bool EachEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool EachOdd(int number)
        {
            return !EachEven(number);
        }
    }
}
