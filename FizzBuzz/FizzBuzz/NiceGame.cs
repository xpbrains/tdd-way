using System;
using System.Text;

namespace FizzBuzz
{
    public abstract class NiceGame
    {
        public string Run(int value)
        {
            GameRules rules = SetupRules();
            if (rules == null)
            {
                throw new GameRulesNotFoundException($"The {this.GetType().Name} game assumes at least one rule to be defined.");
            }

            return rules?.Check(value);
        }

        protected abstract GameRules SetupRules();
    }
}
