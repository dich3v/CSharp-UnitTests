using NUnit.Framework;
using System;
using Task04_BudgetForHoliday;

namespace BudgetForHolidayTests
{
    public class Tests
    {
        [Test]
        [TestCase(1000, 7, 50, 20, "Ivanovi will be left with 450.00 leva after vacation.")]
        [TestCase(2000.33, 8, 74, 15, "Ivanovi will be left with 1137.88 leva after vacation.")]
        [TestCase(111.2, 3, 55.63, 1.2, "57.02 leva needed.")]
        [TestCase(111, 6, 220.63, 20, "1234.98 leva needed.")]
        [TestCase(8000, 20, 150, 60.50, "Ivanovi will be left with 310.00 leva after vacation.")]

        public void Test_BudgetCalc(double budget, int nights, double pricePerNight, double percent, string expected)
        {
            string actual = Program.BudgetCalc(budget, nights, pricePerNight, percent);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(0, 5, 100, 10, "500.00 leva needed.")]
        [TestCase(1500, 0, 50, 30, "Ivanovi will be left with 1050.00 leva after vacation.")]
        [TestCase(2500, 10, 0, 12, "Ivanovi will be left with 2200.00 leva after vacation.")]
        [TestCase(500, 3, 66, 0, "Ivanovi will be left with 302.00 leva after vacation.")]
        public void Test_ZeroInputs(double budget, int nights, double pricePerNight, double percent, string expected)
        {
            string actual = Program.BudgetCalc(budget, nights, pricePerNight, percent);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        [TestCase(-9652, 5, 100.1, 10, "9187.30 leva needed.")]
        [TestCase(1500, -7, 50.11, 30.6, "Ivanovi will be left with 1391.77 leva after vacation.")]
        [TestCase(1.1, 10, -99, 12, "Ivanovi will be left with 941.47 leva after vacation.")]
        [TestCase(500.99, 3, 66, -1.1, "Ivanovi will be left with 308.50 leva after vacation.")]
        public void Test_NegativeInputs(double budget, int nights, double pricePerNight, double percent, string expected)
        {
            string actual = Program.BudgetCalc(budget, nights, pricePerNight, percent);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}