using NUnit.Framework;
using System;
using Task27_SumPairsfromList;

namespace SumPairsFromListTests
{
    public class Tests
    {
        [Test]
        public void Test_SumPairsOddLength()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            string expected = "6 6 3";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SumPairsEvenLength()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
            string expected = "7 7 7";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleElement()
        {
            List<int> list = new List<int> { 1 };
            string expected = "1";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_TwoElements()
        {
            List<int> list = new List<int> { 1, 2 };
            string expected = "3";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyList()
        {
            List<int> list = new List<int> { };
            string expected = "";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            List<int> list = new List<int> { 0 };
            string expected = "0";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NegativeElements()
        {
            List<int> list = new List<int> { -1, -2, -3, -4, -5 };
            string expected = "-6 -6 -3";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedElements()
        {
            List<int> list = new List<int> { -1000, 2, 318, -4, 5, 166, 2, -3, 4, 5, 11, 200, 3, 43964, 0 };
            string expected = "-1000 43966 321 196 16 171 6 -3";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EqualElements()
        {
            List<int> list = new List<int> { 20, 20, 20, 20, 20, 20 };
            string expected = "40 40 40";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MaxMinValues()
        {
            List<int> list = new List<int> { int.MaxValue, int.MinValue };
            string expected = "-1";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AlternatingSigns()
        {
            List<int> list = new List<int> { -1, 1, -1, 1, -1 };
            string expected = "-2 2 -1";

            string actual = Program.SumPairs(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}