using Task80_NumberProcessor;

namespace NumberProcessorTests
{
    public class Tests
    {
        [Test]
        public void Test_SquareEvenNumbers()
        {
            List<int> input = new() { 2, 4, 6 };
            List<double> expected = new() { 4, 16, 36 };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SquareRootOddNumbers()
        {
            List<int> input = new() { 3, 5, 7 };
            List<double> expected = new() { 1.7320508075688772d, 2.2360679774997898d, 2.6457513110645907d };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ZeroInput()
        {
            List<int> input = new() { 0 };
            List<int> expected = new() { 0 };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_EmptyInput()
        {
            List<int> input = new() { };
            List<int> expected = new() { };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_MixedNumbers()
        {
            List<int> input = new() { 2, 3, 4, 5, 6, 7, -2 };
            List<double> expected = new() { 4, 1.7320508075688772d, 16, 2.2360679774997898d, 36, 2.6457513110645907d, -2 };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_NegativeNumbers()
        {
            List<int> input = new() { -2, -4, -6 };
            List<double> expected = new() { -2, -4, -6 };

            List<double> actual = Program.NumberProcessor(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}