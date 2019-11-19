namespace FizzBuzz
{
    public class FizzBuzzGame : NiceGame
    {
        public FizzBuzzGame() : base(
            new GameRules {
                { x=> MultiplesOfThree(x) && MultiplesOfFive(x), "FizzBuzz" },
                { x=> MultiplesOfThree(x), "Fizz" },
                { x=> MultiplesOfFive(x), "Buzz" }
            })
        {

        }

        private static bool MultiplesOfThree(int x)
        {
            return x % 3 == 0;
        }
        private static bool MultiplesOfFive(int x)
        {
            return x % 5 == 0;
        }
    }
}
