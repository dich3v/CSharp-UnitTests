using Task83_GroupNumbers;

namespace GroupNumbersTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyList()
        {
            List<int> input = new();
            string expected = "Even numbers: \r\nOdd numbers: \r\nNegative numbers:";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_EvenAndOddNumbers()
        {
            List<int> input = new() { 1, 2, 3, 4 };
            string expected = "Even numbers: 2, 4\r\nOdd numbers: 1, 3\r\nNegative numbers:";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_OnlyEvenNumbers()
        {
            List<int> input = new() { 2, 4, 6 };
            string expected = "Even numbers: 2, 4, 6\r\nOdd numbers: \r\nNegative numbers:";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_OnlyOddNumbers()
        {
            List<int> input = new() { 1, 3, 5 };
            string expected = "Even numbers: \r\nOdd numbers: 1, 3, 5\r\nNegative numbers:";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_OnlyNegativeNumbers()
        {
            List<int> input = new() { -1, -2, -3 };
            string expected = "Even numbers: \r\nOdd numbers: \r\nNegative numbers: -1, -2, -3";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Duplicates()
        {
            List<int> input = new() { 2, 2, 3, 3, -1, -1 };
            string expected = "Even numbers: 2\r\nOdd numbers: 3\r\nNegative numbers: -1";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsInput()
        {
            List<int> input = new() { 0 };
            string expected = "Even numbers: 0\r\nOdd numbers: \r\nNegative numbers:";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedNumbers()
        {
            List<int> input = new() { -5, -2, 0, 1, 2, 3 };
            string expected = "Even numbers: 0, 2\r\nOdd numbers: 1, 3\r\nNegative numbers: -5, -2";

            string actual = Program.GroupNumbers(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}