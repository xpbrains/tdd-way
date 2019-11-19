using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzResolver
    {
        public string Resove(int value)
        {
            return value % 3 == 0 ? "Fizz" : value.ToString();
        }
    }
}
