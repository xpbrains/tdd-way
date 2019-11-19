using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzResolver
    {
        public string Resove(int value)
        {
            var m3 = value % 3 == 0;
            var m5 = value % 5 == 0;
            if (m3 && m5)
            {
                return "FizzBuzz";
            }
            if (m3)
            {
                return "Fizz";
            }
            if (m5)
            {
                return "Buzz";
            }
            return value.ToString();
        }
    }
}
