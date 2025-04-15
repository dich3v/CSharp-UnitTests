using NUnit.Framework;
using System;
using Task28_GetMultipleOfEvenAndOdds;

namespace GetMultipleOfEvenAndOddsTests
{
    public class Tests
    {
        [Test]
        [TestCase(2834159, 18)]
        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 5)]
        [TestCase(333, 9)]
        [TestCase(666, 0)]
        [TestCase(52, 5)]
        [TestCase(70, 7)]
        [TestCase(80, 0)]
        public void Test_GetSumOfOddDigits(int number, int expected)
        {
            int actual = Program.GetSumOfOddDigits(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(2834159, 14)]
        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(5, 0)]
        [TestCase(333, 0)]
        [TestCase(666, 18)]
        [TestCase(52, 2)]
        [TestCase(70, 0)]
        [TestCase(80, 8)]
        public void Test_GetSumOfEvenDigits(int number, int expected)
        {
            int actual = Program.GetSumOfEvenDigits(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(2834159, 252)]
        [TestCase(-10, 0)]
        [TestCase(0, 0)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        [TestCase(333, 0)]
        [TestCase(666, 0)]
        [TestCase(52, 10)]
        [TestCase(70, 0)]
        [TestCase(80, 0)]
        public void Test_GetMultipleOfEvenAndOdd(int number, int expected)
        {
            int actual = Program.GetMultipleOfEvenAndOdds(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}