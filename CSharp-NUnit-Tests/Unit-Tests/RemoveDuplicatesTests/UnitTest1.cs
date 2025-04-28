using Task79_RemoveDuplicates;

namespace RemoveDuplicatesTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyArray()
        {
            int[] numbers = Array.Empty<int>();
            string expected = string.Empty;

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_RemoveDuplicates()
        {
            int[] numbers = { 1, 5, 6, 7, 7, 1, 4, 9, 9 };
            int[] expected = { 1, 5, 6, 7, 4, 9 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_NoDuplicates()
        {
            int[] numbers = { 1, 5, 6, 0, 4, 9 };
            int[] expected = { 1, 5, 6, 0, 4, 9 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AllDuplicates() 
        { 
            int[] numbers = { 1, 1, 1, 1 };
            int[] expected = { 1 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SingleElement()
        {
            int[] numbers = { 5 };
            int[] expected = { 5 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NegativeAndPositiveNumbers()
        {
            int[] numbers = { -1, -2, -1, 2, 3, 2 };
            int[] expected = { -1, -2, 2, 3 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedData()
        {
            int[] numbers = { 0, 0, 1, -1, -1, 0, 1 };
            int[] expected = { 0, 1, -1 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AllNegativeNumbers()
        {
            int[] numbers = { -3, -3, -2, -2, -1, -1, -3 };
            int[] expected = { -3, -2, -1 };

            int[] actual = Program.RemoveDuplicates(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}