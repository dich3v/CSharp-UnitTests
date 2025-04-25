using Task78_AdjecentEqual;


namespace AdjacentEqualTests
{
    public class AdjacentEqualTests
    {
        [Test]
        public void Test_EmptyList()
        {
            List<int> list = new();

            string expected = string.Empty;
            string actual = Program.Sum(list);

            Assert.That(actual, Is.EqualTo(expected));

        }
        [Test]
        public void Test_NoAdjacentEqualNumbers()
        {
            List<int> list = new() { 1, 2, 3, 4, 5 };

            string expected = "1 2 3 4 5";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_AdjacentEqualNumbers()
        {
            List<int> list = new() { 1, 2, 3, 3, 3, 4, 4, 5 };

            string expected = "1 2 9 8 5";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_AllNumbersAreAdjacentEqual()
        {
            List<int> list = new() { 9, 9, 9, 9, 9, 9 };

            string expected = "54";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_AdjacentEqualNumbersAtBeginning()
        {
            List<int> list = new() { 1, 1, 2, 3, 4, 5 };

            string expected = "2 2 3 4 5";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_AdjacentEqualNumbersAtEnd()
        {
            List<int> list = new() { 1, 2, 3, 4, 5, 5 };

            string expected = "1 2 3 4 10";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void Test_AdjacentEqualNumbersInMiddle()
        {
            List<int> list = new() { 1, 2, 3, 3, 4, 5 };

            string expected = "1 2 6 4 5";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_AdjacentNegativeNumbers()
        {
            List<int> list = new() { -1, -1, -2, -2, -2, -3 };

            string expected = "-2 -6 -3";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_AdjacentMixedNumbers()
        {
            List<int> list = new() { 1, -1, 3, -3, 4, -4 };

            string expected = "1 -1 3 -3 4 -4";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_MultipleAdjacentGroups()
        {
            List<int> list = new() { 1, 1, 2, 3, 3, 4, 5, 5 };

            string expected = "2 2 6 4 10";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_SingleElement()
        {
            List<int> list = new() { 42 };

            string expected = "42";
            string actual = Program.Sum(list);

            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_NullInput()
        {
            List<int> list = null;

            Assert.Throws<NullReferenceException>(() => Program.Sum(list));
        }
        
    }
}