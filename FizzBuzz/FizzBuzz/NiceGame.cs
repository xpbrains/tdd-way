using System;
using System.Text;

namespace FizzBuzz
{
    public abstract class NiceGame
    {
        private readonly GameRules rules;
        public NiceGame(GameRules rules)
        {
            this.rules = rules;
        }

        public string Run(int value)
        {
            return rules.Check(value);
        }
    }
}
