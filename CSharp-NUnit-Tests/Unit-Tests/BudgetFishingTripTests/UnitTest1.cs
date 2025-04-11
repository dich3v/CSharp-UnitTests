using NUnit.Framework;
using System;
using Task03_BudgetFishingTrip;

namespace FishingTripTests
{
    public class Tests
    {
        [Test]
        [TestCase(2000, "Winter", 13, "Yes! You have 50.00 leva left.")]
        [TestCase(5000, "Summer", 10, "Yes! You have 1007.50 leva left.")]
        [TestCase(5500, "Autumn", 23, "Yes! You have 2350.00 leva left.")]
        [TestCase(2333, "Spring", 21, "Yes! You have 83.00 leva left.")]
        public void Test_EnoughBudget(int budget, string season, int fisherman, string expectedMessage)
        {
            string actual = Program.CalculatingTrip(budget, season, fisherman);

            Assert.That(actual, Is.EqualTo(expectedMessage));
        }
        [Test]
        [TestCase(500, "Winter", 1, "Not enough money! You need 1840.00 leva.")]
        [TestCase(3000, "Summer", 11, "Not enough money! You need 570.00 leva.")]
        [TestCase(3600, "Autumn", 6, "Not enough money! You need 180.00 leva.")]
        [TestCase(1500, "Spring", 12, "Not enough money! You need 637.50 leva.")]
        public void Test_NotEnoughBudget(int budget, string season, int fisherman, string expectedMessage)
        {
            string actual = Program.CalculatingTrip(budget, season, fisherman);

            Assert.That(actual, Is.EqualTo(expectedMessage));
        }
        [Test]
        public void Test_ZeroBudget()
        {
            int budget = 0;
            string season = "Winter";
            int fisherman = 3;

            string expected = "Not enough money! You need 2340.00 leva.";

            string actual = Program.CalculatingTrip(budget, season, fisherman);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroFisherman()
        {
            int budget = 4000;
            string season = "Spring";
            int fisherman = 0;

            string expected = "Yes! You have 4000.00 leva left.";

            string actual = Program.CalculatingTrip(budget, season, fisherman);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_InvalidSeason()
        {
            int budget = 3000;
            string season = "Forest";
            int fisherman = 5;

            string expected = "Invalid season!";

            string actual = Program.CalculatingTrip(budget, season, fisherman);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}