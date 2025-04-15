using System;
using Task17_DuplicatedCharactersCount;
using NUnit.Framework;

namespace DuplicatedCharactersCountTests
{
    public class Tests
    {
        [Test]
        public void Test_LowerCaseOnly()
        {
            string input = "radoslav";

            string expected = "r1a2d1o1s1l1v1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_UpperCaseOnly()
        {
            string input = "RADOOSLAAAV";

            string expected = "r1a4d1o2s1l1v1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedCaseInput()
        {
            string input = "RaDDoSSlAv";

            string expected = "r1a2d2o1s2l1v1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NumbersOnly()
        {
            string input = "12344321";

            string expected = "12223242";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NumbersLettersAndSymbols()
        {
            string input = "R@d0osl@v11";

            string expected = "r1@2d101o1s1l1v112";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyInput()
        {
            string input = string.Empty;

            string expected = "";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_InputWithWhiteSpaces()
        {
            string input = "radoslav softuni  ";

            string expected = "r1a2d1o2s2l1v1 3f1t1u1n1i1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleInput()
        {
            string input = "r";

            string expected = "r1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RepeatedInput()
        {
            string input = "rrrrrr";

            string expected = "r6";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RepeatedMixedSequence()
        {
            string input = "a1b2a1b2";

            string expected = "a212b222";
            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Symbols()
        {
            string input = "!@#$%^&*()";

            string expected = "!1@1#1$1%1^1&1*1(1)1";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_CaseInsensitiveEquivalence()
        {
            string input = "AaA";

            string expected = "a3";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_OrderOfAppearance()
        {
            string input = "babab";

            string expected = "b3a2";

            string actual = Program.GetCharacterCounts(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}