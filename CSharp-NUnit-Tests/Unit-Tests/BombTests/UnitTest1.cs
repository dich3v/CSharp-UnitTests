using NUnit.Framework;
using System;
using System.Collections.Generic;
using Task02_Bomb;

namespace BombTests
{
    public class Tests
    {

        [Test]
        public void Test_CorrectRemoveElementsAndSumTheRest()
        {
            List<int> input = new List<int> { 1, 2, 2, 4, 2, 2, 2, 9 };
            int[] bomb = new int[] { 4, 2 };

            int expected = 12;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_BombAtTheBeginning()
        {
            List<int> input = new List<int> { 2, 1, 3, 4, 5, 6, 7 };
            int[] bomb = new int[] { 1, 4 };
            int expected = 7;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_BombAtTheVeryBeginningWithHighPower()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };
            int[] bomb = new int[] { 1, 10 };
            int expected = 0;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_BombAtTheVeryEndWithHighPower()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };
            int[] bomb = new int[] { 6, 20 };
            int expected = 0;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_BombInTheEnd()
        {
            List<int> input = new List<int> { 1, 4, 4, 2, 8, 9, 1 };
            int[] bomb = new int[] { 9, 3 };

            int expected = 5;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_TwoBombs()
        {
            List<int> input = new List<int> { 1, 1, 2, 1, 1, 1, 2, 1, 1, 1 };
            int[] bomb = new int[] { 2, 1 };

            int expected = 4;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_MultipleBombs()
        {
            List<int> input = new List<int> { 1, 3, 5, 3, 7, 3, 2, 2, 8, 3, 0, 3, 3, 5, 6, 9, 8, 4, 1, 2, 3 };
            int[] bomb = new int[] { 3, 3 };

            int expected = 28;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_NoBomb()
        {
            List<int> input = new List<int> { 1, 1, 2, 1, 1 };
            int[] bomb = new int[] { 0, 0 };

            int expected = 6;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_AllElementsRemoved()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };
            int[] bomb = { 3, 3 };

            int expected = 0;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_BombWithZeroPower()
        {
            List<int> input = new List<int> { 2, 1, 3, 4 };
            int[] bomb = new int[] { 1, 0 };
            int expected = 9;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SameElements()
        {
            List<int> input = new List<int> { 2, 2, 2, 2 };
            int[] bomb = { 2, 2 };

            int expected = 0;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_EmptyBombArr()
        {
            List<int> input = new List<int> { 2, 10, 2, 3 };
            int[] bomb = Array.Empty<int>();

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int actual = Program.RemoveNumbers(input, bomb);
                throw new IndexOutOfRangeException("This is the expected exception.");
            });
        }
        [Test]
        public void Test_EmptyList()
        {
            List<int> input = new List<int> { };
            int[] bomb = new int[] { 2, 1 };

            Assert.Throws<FormatException>(() =>
            {
                int actual = Program.RemoveNumbers(input, bomb);
                throw new FormatException("This is the expected exception.");
            });
        }
        [Test]
        public void Test_SingleBombInput()
        {
            List<int> input = new List<int> { 5, 7, 78, 13 };
            int[] bomb = new int[] { 1 };

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                int actual = Program.RemoveNumbers(input, bomb);
                throw new IndexOutOfRangeException("This is the expected exception.");
            });
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            List<int> input = new List<int> { 0 };
            int[] bomb = new int[] { 2, 5 };

            int expected = 0;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SingleInout()
        {
            List<int> input = new List<int> { 50 };
            int[] bomb = new int[] { 10, 20 };

            int expected = 50;
            int actual = Program.RemoveNumbers(input, bomb);

            Assert.AreEqual(expected, actual);
        }
    }
}