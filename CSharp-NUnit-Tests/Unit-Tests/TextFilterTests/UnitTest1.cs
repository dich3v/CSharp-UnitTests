using System;
using NUnit.Framework;
using Task66_TextFilter;

namespace TextFilterTests
{
    public class Tests
    {
        [Test]
        public void Test_FilterText()
        {
            string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
            string[] bannedWords = new string[] { "Linux", "Windows" };

            string expected = "It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FilterSingleWord()
        {
            string text = "Linux";
            string[] bannedWords = new string[] { "Linux", "Windows" };

            string expected = "*****";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FilterNoBannedWords()
        {
            string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
            string[] bannedWords = new string[] { "Car", "Cat" };

            string expected = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyArray()
        {
            string text = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";
            string[] bannedWords = new string[] { };

            string expected = "It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FilterOnlyBannedWords()
        {
            string text = "star star star star star star star star star star star star star";
            string[] bannedWords = new string[] { "star" };

            string expected = "**** **** **** **** **** **** **** **** **** **** **** **** ****";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NoTextForFiltering()
        {
            string text = "";
            string[] bannedWords = new string[] { "star" };

            string expected = "";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_CaseSensitiveReplacement()
        {
            string text = "linux Linux LiNuX";
            string[] bannedWords = new string[] { "linux" };

            string expected = "***** Linux LiNuX";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordAsSubstring()
        {
            string text = "The catalog has cats.";
            string[] bannedWords = new string[] { "cat" };

            string expected = "The ***alog has ***s.";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RepeatedBannedWord()
        {
            string text = "LinuxLinuxLinux";
            string[] bannedWords = new string[] { "Linux" };

            string expected = "***************";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_BannedWordsWithSpecialCharacters()
        {
            string text = "@!_&%$ cat dog ()()";
            string[] bannedWords = new string[] { "@!_&%$", "()()" };

            string expected = "****** cat dog ****";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AstericksAsTextAndBannedWord()
        {
            string text = "*** I want icecream ***";
            string[] bannedWords = new string[] { "***" };

            string expected = "*** I want icecream ***";

            string actual = Program.ReplaceBannedWords(text, bannedWords);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}