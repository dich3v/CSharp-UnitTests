using System;
using NUnit.Framework;
using Task55_ShiftElementsInArray;

namespace ShiftElementsInArrayTests
{
    public class Tests
    {
        [Test]
        public void Test_CorrectShiftingElements()
        {
            int[] ints = { 5, 6, 3, 2 };
            int shifts = 2;
            int[] expected = { 3, 2, 5, 6 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleElement()
        {
            int[] ints = { 5 };
            int shifts = 10;
            int[] expected = { 5 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyArray()
        {
            int[] ints = { };
            int shifts = 20;
            int[] expected = { };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_TwoElements()
        {
            int[] ints = { 15, 200 };
            int shifts = 2;
            int[] expected = { 15, 200 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_LargeInput()
        {
            int[] ints = { 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0, 888, 13, 99, 135974, -11, 16 };
            int shifts = 100;
            int[] expected = { 99, 135974, -11, 16, 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0, 888, 13 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroShifts()
        {
            int[] ints = { 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0, 888, 13, 99 };
            int shifts = 0;
            int[] expected = { 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0, 888, 13, 99 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ShiftsEqualToLength()
        {
            int[] ints = { 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0 };
            int shifts = 10;
            int[] expected = { 5, 50, 5050, 9, 18, 53, 1, -6, 0, 0 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NegativeShiftsThrowException()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            int shifts = -2;

            Assert.Throws<IndexOutOfRangeException>(() => Program.RotateArray(ints, shifts));
        }
        [Test]
        public void Test_ShiftsGreaterThanLength()
        {
            int[] ints = { 10, 20, 30, 40 };
            int shifts = 6;
            int[] expected = { 30, 40, 10, 20 };

            int[] actual = Program.RotateArray(ints, shifts);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}