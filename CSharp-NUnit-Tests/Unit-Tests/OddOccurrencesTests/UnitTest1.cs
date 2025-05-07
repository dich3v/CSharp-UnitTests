using Task84_OddOccurrences;

namespace OddOccurrencesTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyArray()
        {
            string[] input = new string[0];

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_NoOddOccurrences()
        {
            string[] input = { "apple", "banana", "apple", "banana" };

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_SingleOddOccurrence()
        {
            string[] input = { "apple", "banana", "apple" };

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo("banana"));
        }

        [Test]
        public void Test_MultipleOddOccurrences()
        {
            string[] input = { "apple", "banana", "apple", "kiwi", "kiwi", "mango", "cherry" };
            string expected = "banana mango cherry";

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_MixedCaseWords()
        {
            string[] input = { "Apple", "apple", "BANANA", "banana", "Cherry" };

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo("cherry"));
        }

        [Test]
        public void Test_AllWordsOddOccurrences()
        {
            string[] input = { "apple", "banana", "cherry" };
            string expected = "apple banana cherry";

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_RepeatedOddOccurrences()
        {
            string[] input = { "apple", "apple", "apple" };

            string actual = Program.FindOdd(input);

            Assert.That(actual, Is.EqualTo("apple"));
        }
    }
}