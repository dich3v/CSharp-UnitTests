using NUnit.Framework;
using System;
using System.Text;
using Task_ConcatenatedWords;

namespace ConcatenatedWordsTests
{
    public class Tests
    {
        [Test]
        public void Test_ConcatenatedSingleWord()
        {
            string[] input = { "rado" };

            StringBuilder expected = new StringBuilder("radoradoradorado");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedSingleChar()
        {
            string[] input = { "r" };

            StringBuilder expected = new StringBuilder("r");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedWords()
        {
            string[] input = { "rado", "ab", "da", "ne" };

            StringBuilder expected = new StringBuilder("radoradoradoradoababdadanene");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_EmptyArr()
        {
            string[] input = { };

            StringBuilder expected = new StringBuilder();

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedWordsWithSpaces()
        {
            string[] input = { "cat dog" };

            StringBuilder expected = new StringBuilder("cat dogcat dogcat dogcat dogcat dogcat dogcat dog");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedSpecialChars()
        {
            string[] input = { "a!b@", "c#d$", "e%f^" };

            StringBuilder expected = new StringBuilder("a!b@a!b@a!b@a!b@c#d$c#d$c#d$c#d$e%f^e%f^e%f^e%f^");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedSingleChars()
        {
            string[] input = { "a", "b", "c" };

            StringBuilder expected = new StringBuilder("abc");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedMixedCaseWords()
        {
            string[] input = { "HeLLo", "WoRLd" };

            StringBuilder expected = new StringBuilder("HeLLoHeLLoHeLLoHeLLoHeLLoWoRLdWoRLdWoRLdWoRLdWoRLd");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
        [Test]
        public void Test_ConcatenatedNonAlpha()
        {
            string[] input = { "123", "@#$" };

            StringBuilder expected = new StringBuilder("123123123@#$@#$@#$");

            StringBuilder actual = Program.ConcatenateString(input);

            Assert.That(actual.ToString(), Is.EqualTo(expected.ToString()));
        }
    }
}