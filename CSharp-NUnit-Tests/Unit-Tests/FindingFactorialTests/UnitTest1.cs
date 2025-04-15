using NUnit.Framework;
using System;
using Task24_FindingFactorial;

namespace FindingFactorialTests
{
    public class Tests
    {
        [Test]
        public void Test_ValidNumber()
        {
            int input = 10;

            int expected = 3628800;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            int input = 0;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(1));
        }
        [Test]
        public void Test_NegativeNumber()
        {
            int input = -5;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(1));
        }
        [Test]
        public void Test_OneAsInput()
        {
            int input = 1;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(1));
        }
        [Test]
        public void Test_LargeNumber()
        {
            int input = 1000;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(0));
        }
        [Test]
        public void Test_ConsecutiveValues()
        {
            int input1 = 4;
            int input2 = 5;

            int actual1 = Program.FindFactorial(input1);
            int actual2 = Program.FindFactorial(input2);

            Assert.That(actual1, Is.EqualTo(24));
            Assert.That(actual2, Is.EqualTo(120));
        }
        [Test]
        public void Test_MaxIntFactorial()
        {
            int input = 12;
            int expected = 479001600;

            int actual = Program.FindFactorial(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}