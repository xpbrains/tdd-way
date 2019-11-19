using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzResolver
    {
        public string Resove(int value)
        {

            if (value % 3 == 0)
            {
                return "Fizz";
            }
            if (value % 5 == 0)
            {
                return "Buzz";
            }
            return value.ToString();
        }
    }
}
