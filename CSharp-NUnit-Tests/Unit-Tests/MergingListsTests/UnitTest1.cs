using System;
using Task40_MergingLists;

namespace MergingListsTests
{
    public class Tests
    {
        [Test]
        public void Test_MergingEqualLengthLists()
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> secondList = new List<int> { 5, 6, 7, 8, 9, 10 };
            string expected = "1 5 2 6 3 7 4 8 5 9 6 10";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_FirstListGreaterLength()
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4 };
            List<int> secondList = new List<int> { 5, 6, 7, 8, 9, 10 };
            string expected = "1 5 2 6 3 7 4 8 9 10";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_SecondListGreaterLength()
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> secondList = new List<int> { 5, 6, 7, 8, 9 };
            string expected = "1 5 2 6 3 7 4 8 5 9 6";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_FirstListEmpty()
        {
            List<int> firstList = new List<int> { };
            List<int> secondList = new List<int> { 5, 6, 7, 8, 9 };
            string expected = "5 6 7 8 9";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_SecondListEmpty()
        {
            List<int> firstList = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> secondList = new List<int> { };
            string expected = "1 2 3 4 5 6";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_BothListsEmpty()
        {
            List<int> firstList = new List<int> { };
            List<int> secondList = new List<int> { };
            string expected = "";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_NegativeElements()
        {
            List<int> firstList = new List<int> { -10, 235, 0, -99 };
            List<int> secondList = new List<int> { 13, 0, 0, -55, -1956 };
            string expected = "-10 13 235 0 0 0 -99 -55 -1956";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_EqualElementsAsInputs()
        {
            List<int> firstList = new List<int> { 5, 5, 5, 5 };
            List<int> secondList = new List<int> { 5, 5, 5, 5 };
            string expected = "5 5 5 5 5 5 5 5";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_MaxAndMinValue()
        {
            List<int> firstList = new List<int> { int.MaxValue };
            List<int> secondList = new List<int> { int.MinValue };
            string expected = "2147483647 -2147483648";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_NullInputs()
        {
            Assert.Throws<NullReferenceException>(() => Program.MergeLists(null, new List<int>()));
            Assert.Throws<NullReferenceException>(() => Program.MergeLists(new List<int>(), null));
        }
        [Test]
        public void Test_SignleElements()
        {
            List<int> firstList = new List<int> { 1 };
            List<int> secondList = new List<int> { 2 };
            string expected = "1 2";

            string actual = Program.MergeLists(firstList, secondList);

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}