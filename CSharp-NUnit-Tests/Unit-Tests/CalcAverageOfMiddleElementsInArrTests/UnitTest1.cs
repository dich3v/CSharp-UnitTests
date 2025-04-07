using NUnit.Framework;
using System;
using Task_CalcAverageOfMiddleElementsInArr;

namespace CalcAverageOfMiddleElementsInArrTests
{
    public class Tests
    {
        [Test]
        public void Test_EvenCountElements()
        {
            int[] input = { 10, 20, 30, 40 };

            string expected = "25.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_OddCountElements()
        {
            int[] input = { 100, 20, 30 };

            string expected = "20.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroInput()
        {
            int[] input = { 0, 0, 0, 0, 0 };

            string expected = "0.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleElement()
        {
            int[] input = { 565 };

            string expected = "565.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SameElementMultipleOccurrences()
        {
            int[] input = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };

            string expected = "2.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_LongOddCountInput()
        {
            int[] input = { 13, 255, 1000, 2234, 21, 0, 55, 999, 151552, 6666 };

            string expected = "10.50";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_LongEvenCountInput()
        {
            int[] input = { 755, 9986, 23213, 132154, 5677165, 112323, 678998676, 22222, 103494 };

            string expected = "5677165.00";

            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyArray()
        {
            int[] input = { };

            Assert.Throws<IndexOutOfRangeException>(() => Program.FindSumOfMiddleIndexes(input));
        }
        [Test]
        public void Test_NegativeNumbers()
        {
            int[] input = { -10, -20, -30, -40 };

            string expected = "-25.00";
            string actual = Program.FindSumOfMiddleIndexes(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}