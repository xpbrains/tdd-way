using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Resolvers : IEnumerable
    {
        private IDictionary<Func<int, bool>, string> rules = new Dictionary<Func<int, bool>, string> ();

        public IEnumerator GetEnumerator()
        {
            return rules.GetEnumerator();
        }

        public void Add(Func<int, bool> func, string value)
        {
            rules.Add(func, value);
        }

        public string Resove(int value)
        {

            foreach (var check in rules)
            {
                if (check.Key(value))
                    return check.Value;
            }
            return value.ToString();
        }

    }
}
