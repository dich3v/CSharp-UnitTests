using Task82_CharacterCounter;

namespace CharacterCounterTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyList()
        {
            List<string> input = new();

            string actual = Program.Count(input);

            Assert.That(actual, Is.Empty);
        }
        [Test]
        public void Test_WithNoCharacters()
        {
            List<string> input = new(){ "" };

            string actual = Program.Count(input);

            Assert.That(actual, Is.Empty);
        }
        [Test]
        public void Test_WithSingleCharacter()
        {
            List<string> input = new() { "a" };
            string expected = "a -> 1";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WithMultipleCharacters()
        {
            List<string> input = new() { "cat cat dog" };
            string expected = "c -> 2\r\na -> 2\r\nt -> 2\r\n  -> 2\r\nd -> 1\r\no -> 1\r\ng -> 1";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WithSpecialCharacters()
        {
            List<string> input = new() { "#@!£$%&*&%$£}{[][]" };
            string expected = "# -> 1\r\n@ -> 1\r\n! -> 1\r\n£ -> 2\r\n$ -> 2\r\n% -> 2\r\n& -> 2\r\n* -> 1\r\n} -> 1\r\n{ -> 1\r\n[ -> 2\r\n] -> 2";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedCharacters()
        {
            List<string> input = new() { "M! n@m3 1S Radd0slAv Dich3V123" };
            string expected = "M -> 1\r\n! -> 1\r\n  -> 4\r\nn -> 1\r\n@ -> 1\r\nm -> 1\r\n3 -> 3\r\n1 -> 2\r\nS -> 1\r\nR -> 1\r\na -> 1\r\nd -> 2\r\n0 -> 1\r\ns -> 1\r\nl -> 1\r\nA -> 1\r\nv -> 1\r\nD -> 1\r\ni -> 1\r\nc -> 1\r\nh -> 1\r\nV -> 1\r\n2 -> 1";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_LongChar()
        {
            List<string> input = new() { "hhhhhhhhhhhhhhhhhhhhhh" };
            string expected = "h -> 22";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_WhiteSpaces()
        {
            List<string> input = new() { "                                     " };
            string expected = "-> 37";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_CaseSensitivity()
        {
            List<string> input = new() { "AaAa" };
            string expected = "A -> 2\r\na -> 2";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MultipleStringsInList()
        {
            List<string> input = new() { "abc", "def", "abc" };
            string expected = "a -> 2\r\nb -> 2\r\nc -> 2\r\nd -> 1\r\ne -> 1\r\nf -> 1";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NumbersOnly()
        {
            List<string> input = new() { "123123" };
            string expected = "1 -> 2\r\n2 -> 2\r\n3 -> 2";

            string actual = Program.Count(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}