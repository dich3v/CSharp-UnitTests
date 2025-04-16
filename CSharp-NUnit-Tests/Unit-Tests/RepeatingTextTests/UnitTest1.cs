using System;
using NUnit.Framework;
using Task52_RepeatingText;

namespace RepeatingTextTests
{
    public class Tests
    {
        [Test]
        [TestCase("text", 3, "texttexttext")]
        [TestCase("s0ftun1", 2, "s0ftun1s0ftun1")]
        [TestCase("£$%^&*()", 1, "£$%^&*()")]
        [TestCase("text", 0, "")]
        [TestCase("131819", -6, "")]
        [TestCase("", 3, "")]
        [TestCase("R", 10, "RRRRRRRRRR")]
        public void Test_RepeatedText(string input, int repeat, string expected)
        {
            string actual = Program.RepeatedText(input, repeat);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}