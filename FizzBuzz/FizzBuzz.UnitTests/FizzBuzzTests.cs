using System;
using NUnit.Framework;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        public void ShouldProduceInputValueWhenNotMultiplesOfThree(int value)
        {
            // Arrange
            string expected =$@"{value}";

            var fb = new FizzBuzzResolver();

            // Act
            var actual = fb.Resove(value);

            //Assert
            Assert.That<string>(actual, Is.EqualTo(expected));
        }



        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]
        public void ShouldProduceFizzWhenMultiplesOfThree(int value)
        {
            // Arrange
            string expected = "Fizz";

            var fb = new FizzBuzzResolver();

            // Act
            var actual = fb.Resove(value);

            //Assert
            Assert.That<string>(actual,Is.EqualTo(expected));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]
        public void ShouldProduceBuzzWhenMultiplesOfFive(int value)
        {
            // Arrange
            string expected = "Buzz";

            var fb = new FizzBuzzResolver();

            // Act
            var actual = fb.Resove(value);

            //Assert
            Assert.That<string>(actual, Is.EqualTo(expected));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void ShouldProduceFizzBuzzWhenMultiplesOfThreeOfFive(int value)
        {
            // Arrange
            string expected = "FizzBuzz";

            var fb = new FizzBuzzResolver();

            // Act
            var actual = fb.Resove(value);

            //Assert
            Assert.That<string>(actual, Is.EqualTo(expected));
        }


    }
}