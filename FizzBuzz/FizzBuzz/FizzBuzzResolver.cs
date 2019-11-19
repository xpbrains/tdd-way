using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private Resolvers context;
        public FizzBuzzGame()
        {
            context = new Resolvers
            {
                { x=> MultiplesOfThree(x) && MultiplesOfFive(x), "FizzBuzz" },
                { x=> MultiplesOfThree(x), "Fizz" },
                { x=> MultiplesOfFive(x), "Buzz" }
            };
        }

        private bool MultiplesOfThree(int value) => value % 3 == 0;
        private bool MultiplesOfFive(int value) => value % 5 == 0;

        public string Run(int value)
        {
            return context.Resove(value);
        }
    }
}
