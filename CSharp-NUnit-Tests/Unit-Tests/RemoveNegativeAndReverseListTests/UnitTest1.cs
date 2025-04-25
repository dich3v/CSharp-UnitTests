using Task50_RemoveNegativeAndReverseList;

namespace RemoveNegativeAndReverseListTests
{
    public class Tests
    {
        [Test]
        public void Test_RemoveNegativeAndReverse()
        {
            List<int> list = new() { 5, 13, -1, 2, -5 };

            string expected = "2 13 5";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_OnlyNegatives()
        {
            List<int> list = new() { -5, -13, -1, -2, -5 };

            string expected = "empty";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_OnlyPositives()
        {
            List<int> list = new() { 5, 13, 1, 2, 5 };

            string expected = "5 2 1 13 5";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AdjecentPositiveElements()
        {
            List<int> list = new() { 9, 9, 9, 9, 9 };

            string expected = "9 9 9 9 9";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AdjecentNegativeElements()
        {
            List<int> list = new() { -9, -9, -9, -9, -9 };

            string expected = "empty";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_AdjecentMixedElements()
        {
            List<int> list = new() { -9, 9, -9, 9, -9 };

            string expected = "9 9";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SignleElement()
        {
            List<int> list = new() { 0 };

            string expected = "0";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_OneNegativeOnePositive()
        {
            List<int> list = new() { -9, 9 };

            string expected = "9";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EmptyList()
        {
            List<int> list = new() {  };

            string expected = "empty";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MultipleZeros()
        {
            List<int> list = new() { 0, 0, 0, -1, -2 };

            string expected = "0 0 0";
            string actual = Program.RemoveNegativeNumsAndReverse(list);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}