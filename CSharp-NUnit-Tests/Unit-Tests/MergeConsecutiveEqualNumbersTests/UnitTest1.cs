using NUnit.Framework;
using System;
using Task39_MergeConsecutiveEqualNumbers;

namespace MergeConsecutiveEqualNumbersTests
{
    public class Tests
    {
        [Test]
        public void Test_MergeEquals()
        {
            List<int> list = new List<int> { 11, 11, 13, 15, 778, 26, 26, 15, 999 };

            string expected = "22 13 15 778 52 15 999";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MergeOnlyEqualsElements()
        {
            List<int> list = new List<int> { 11, 11, 11, 11, 11 };

            string expected = "44 11";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MergeSingleElement()
        {
            List<int> list = new List<int> { 999 };

            string expected = "999";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MergeNegative()
        {
            List<int> list = new List<int> { -11, -11, 11, 13, -15, 778, -26, -26, 15, 999 };

            string expected = "-22 11 13 -15 778 -52 15 999";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            List<int> list = new List<int> { 0 };

            string expected = "0";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyList()
        {
            List<int> list = new List<int> { };

            string expected = "";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MergeNegativeAndPositiveWithSameValue()
        {
            List<int> list = new List<int> { 10, -10, 10, -10, 10, -10 };

            string expected = "10 -10 10 -10 10 -10";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MergeEvenCount()
        {
            List<int> list = new List<int> { 4, 4, 4, 4 };

            string expected = "16";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RecursiveMerging()
        {
            List<int> list = new List<int> { 2, 2, 4, 4 };

            string expected = "8 4";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NoEqualForMerging()
        {
            List<int> list = new List<int> { 5, 6, 5 };

            string expected = "5 6 5";

            string actual = Program.MergeNumbers(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}