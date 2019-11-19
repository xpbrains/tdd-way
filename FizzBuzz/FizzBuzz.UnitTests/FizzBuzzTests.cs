using System;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3,ExpectedResult = "Fizz")]
        [TestCase(6, ExpectedResult = "Fizz")]
        [TestCase(9, ExpectedResult = "Fizz")]
        [TestCase(12, ExpectedResult = "Fizz")]
        [TestCase(15, ExpectedResult = "Fizz")]
        public void ShouldProduceFizzWhenMultiplesOfThree(int value, string expected)
        {
            var fb = new FizzBuzzResolver();
            var actual = fb.Resove(value);
            Assert.That<string>(actual,Is.EqualTo(expected));
        }

    }
}