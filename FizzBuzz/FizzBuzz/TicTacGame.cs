using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    class TicTacGame : NiceGame
    {
        public TicTacGame()
        {
            Console.WriteLine($"Game  {nameof(TicTacGame)} started.");
        }
        protected override GameRules SetupRules()
        {
            return new GameRules
            {
                { EachOdd,  "Tic" },
                { EachEven, "Tac" }
            };
        }

        private bool EachEven(int number)
        {
            return number % 2 == 0;
        }

        private bool EachOdd(int number)
        {
            return !EachEven(number);
        }

    }
}
