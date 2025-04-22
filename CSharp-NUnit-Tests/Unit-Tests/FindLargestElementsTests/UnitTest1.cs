using System;
using NUnit.Framework;
using Task21_FindLargestElements;

namespace FindLargestElementsTests
{
    public class Tests
    {
        [Test]
        public void Test_FindLargestElements()
        {
            List<int> list = new List<int> { 2, 7, 5, 3, 1, 6 };
            string expected = "7 6";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FindLargestSingleElement()
        {
            List<int> list = new List<int> { 10 };
            string expected = "10";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyList()
        {
            List<int> list = new List<int> { };
            
            Assert.Throws<InvalidOperationException>(() => Program.FindLargestElements(list));
        }
        [Test]
        public void Test_EqualElements()
        {
            List<int> list = new List<int> { 2, 2, 2, 2, 2, 2 };
            string expected = "2";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NegativeElements()
        {
            List<int> list = new List<int> { -44, -20, -8, -1, -99 };
            string expected = "-1 -99";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            List<int> list = new List<int> { 0 };
            string expected = "0";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedElements()
        {
            List<int> list = new List<int> { 11, 6, -2, 0, 0, 16, 11, -4, 1 };
            string expected = "16 11 1";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AllElementsReturned()
        {
            List<int> list = new List<int> { 5, 4, 3, 2, 1 };
            string expected = "5 4 3 2 1";

            string actual = Program.FindLargestElements(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}