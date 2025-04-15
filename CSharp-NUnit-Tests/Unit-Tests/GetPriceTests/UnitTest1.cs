using System;
using NUnit.Framework;
using Task29_GetPrice;

namespace GetPriceTests
{
    public class Tests
    {
        [Test]
        [TestCase("coffee", 5, 7.50)]
        [TestCase("water", 8, 8.00)]
        [TestCase("coke", 14, 19.60)]
        [TestCase("snacks", 9, 18.00)]
        [TestCase("coffee", 1, 1.50)]
        [TestCase("water", 1, 1.00)]
        [TestCase("coke", 1, 1.40)]
        [TestCase("snacks", 1, 2.00)]
        public void TestGetPriceValidInputs(string product, int quantity, double expected)
        {
            double actual = Program.GetPrice(product, quantity);

            Assert.That(actual, Is.EqualTo(expected).Within(0.001));
        }
        [Test]
        [TestCase("car", 11, 0.00)]
        [TestCase("water", 0, 0.00)]
        [TestCase("COKE", 14, 0.00)]
        [TestCase("", 9, 0.00)]
        [TestCase("Water", 7, 0.00)]
        [TestCase("water", -3, -3.00)]
        public void TestGetPriceInvalidInputs(string product, int quantity, double expected)
        {
            double actual = Program.GetPrice(product, quantity);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}