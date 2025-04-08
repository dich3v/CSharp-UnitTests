using NUnit.Framework;
using System;
using Task_CardsGame;


namespace CardGameTests
{
    public class Tests
    {
        [Test]
        public void Test_FirstPLayerWins()
        {
            List<int> firstPlayer = new List<int> { 20, 30, 40, 50 };
            List<int> secondPlayer = new List<int> { 10, 20, 30, 40 };

            string expected = "First player wins! Sum: 240";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SecondPLayerWins()
        {
            List<int> firstPlayer = new List<int> { 10, 20, 30, 40, 50 };
            List<int> secondPlayer = new List<int> { 50, 40, 30, 30, 10 };

            string expected = "Second player wins! Sum: 50";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FirstPLayerWinsWithSingleElement()
        {
            List<int> firstPlayer = new List<int> { 55 };
            List<int> secondPlayer = new List<int> { 43 };

            string expected = "First player wins! Sum: 98";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SecondPLayerWinsWithSingleElement()
        {
            List<int> firstPlayer = new List<int> { 88 };
            List<int> secondPlayer = new List<int> { 136 };

            string expected = "Second player wins! Sum: 224";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_EqualElements()
        {
            List<int> firstPlayer = new List<int> { 1, 34, 28, 16 };
            List<int> secondPlayer = new List<int> { 1, 34, 28, 16 };

            string expected = "Second player wins! Sum: 0";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NegativeElements()
        {
            List<int> firstPlayer = new List<int> { -50, 63, -2358, 0 };
            List<int> secondPlayer = new List<int> { 0, 380, -24, -583 };

            string expected = "Second player wins! Sum: -2572";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ZeroAsElements()
        {
            List<int> firstPlayer = new List<int> { 0, 0, 0 };
            List<int> secondPlayer = new List<int> { 0, 0, 0 };

            string expected = "Second player wins! Sum: 0";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SecondListCountShorter()
        {
            List<int> firstPlayer = new List<int> { 20, 50, 100 };
            List<int> secondPlayer = new List<int> { 18, 43 };

            string expected = "First player wins! Sum: 231";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FirstListCountShorter()
        {
            List<int> firstPlayer = new List<int> { 1, 2, 3 };
            List<int> secondPlayer = new List<int> { 4, 5, 6, 7 };

            string expected = "Second player wins! Sum: 28";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_FirstListEmpty()
        {
            List<int> firstPlayer = new List<int> { };
            List<int> secondPlayer = new List<int> { 18, 43 };

            string expected = "Second player wins! Sum: 61";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_SecondListEmpty()
        {
            List<int> firstPlayer = new List<int> { 1, 2, 3 };
            List<int> secondPlayer = new List<int> { };

            string expected = "First player wins! Sum: 6";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_BothListsEmpty()
        {
            List<int> firstPlayer = new List<int> { };
            List<int> secondPlayer = new List<int> { };

            string expected = "Second player wins! Sum: 0";

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_CycleLikeScenarioTerminates()
        {
            List<int> firstPlayer = new List<int> { 10, 20 };
            List<int> secondPlayer = new List<int> { 20, 10 };

            string actual = Program.CardGame(firstPlayer, secondPlayer);

            Assert.That(actual, Does.Contain("player wins! Sum:"));
        }
    }
}