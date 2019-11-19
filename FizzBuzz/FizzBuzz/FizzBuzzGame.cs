using System;

namespace FizzBuzz
{
    public class FizzBuzzGame : NiceGame
    {
        public FizzBuzzGame()
        {
            Console.WriteLine($"Game {nameof(FizzBuzz)} started.");
        }
        protected override GameRules SetupRules()
        {
            return new GameRules {
                { x=> MultiplesOfThree(x) && MultiplesOfFive(x), "FizzBuzz" },
                { x=> MultiplesOfThree(x), "Fizz" },
                { x=> MultiplesOfFive(x), "Buzz" }
            };
        }
        private bool MultiplesOfThree(int x)
        {
            return x % 3 == 0;
        }
        private bool MultiplesOfFive(int x)
        {
            return x % 5 == 0;
        }


    }
}
