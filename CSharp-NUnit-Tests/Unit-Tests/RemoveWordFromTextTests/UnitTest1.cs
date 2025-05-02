using System;
using Task51_RemoveWordFromText;

namespace RemoveWordFromTextTests
{
    public class Tests
    {
        [Test]
        public void Test_RemoveSingleWordInText()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            string wordtoRemove = "fox";
  
            string expected = "The quick brown jumps over the lazy dog";
            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RemoveWordMultipleOccurencies()
        {
            string input = "The fox quick brown fox jumps over the fox fox lazy dog";
            string wordtoRemove = "fox";

            string expected = "The quick brown jumps over the lazy dog";
            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RemoveWordUpperCase()
        {
            string input = "The Fox quick brown FOX jumps over the foX fox lazy dog";
            string wordtoRemove = "fox";
 
            string expected = "The quick brown jumps over the lazy dog";
            string actual = Program.RemoveWord(input, wordtoRemove);
 
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RemoveWordWhiteSpaces()
        {
            string input = "The     Fox quick   brown FOX jumps over the foX lazy dog     ";
            string wordtoRemove = "fox";

            string expected = "The quick brown jumps over the lazy dog";
            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_RemoveSingleWordWithWhitespaces()
        {
            string input = "  cat ";
            string wordtoRemove = "cat";

            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.Empty);
        }
        [Test]
        public void Test_EmptyString()
        {
            string input = string.Empty;
            string wordtoRemove = "cat";

            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.Empty);
        }
        [Test]
        public void Test_NoWordToRemove()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            string wordtoRemove = " ";

            string expected = "Thequickbrownfoxjumpsoverthelazydog";

            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordToRemoveUpperCase()
        {
            string input = "The quick brown fox jumps over the lazy dog";
            string wordtoRemove = "FOX";

            string expected = "The quick brown jumps over the lazy dog";

            string actual = Program.RemoveWord(input, wordtoRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordAtStart()
        {
            string input = "fox jumps over the lazy dog";
            string wordToRemove = "fox";

            string expected = "jumps over the lazy dog";

            string actual = Program.RemoveWord(input, wordToRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordAtEnd()
        {
            string input = "The quick brown fox";
            string wordToRemove = "fox";

            string expected = "The quick brown";

            string actual = Program.RemoveWord(input, wordToRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordAtStartAndEnd()
        {
            string input = "fox jumps over the lazy fox";
            string wordToRemove = "fox";

            string expected = "jumps over the lazy";

            string actual = Program.RemoveWord(input, wordToRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WordWithSpecialCharacters()
        {
            string input = "The quick brown fox! jumps over the lazy dog";
            string wordToRemove = "fox!";

            string expected = "The quick brown jumps over the lazy dog";

            string actual = Program.RemoveWord(input, wordToRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleCharacterString()
        {
            string input = "f";
            string wordToRemove = "f";

            string expected = "";

            string actual = Program.RemoveWord(input, wordToRemove);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}