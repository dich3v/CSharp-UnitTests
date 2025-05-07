using Task53_ResourcesQuantity;

namespace ResourcesQuantityTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyInput()
        {
            List<string> input = new List<string>();

            string actual = Program.Miner(input);

            Assert.That(actual, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_MixedCaseResources()
        {
            List<string> input = new List<string> { "Gold", "5", "gold", "3", "SiLvEr", "10", "SILVER", "20" };
            string expected = $"gold -> 8{Environment.NewLine}silver -> 30";

            string actual = Program.Miner(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_DifferentResources()
        {
            List<string> input = new List<string> { "Iron", "10", "Coal", "5", "iron", "15", "COAL", "5", "Gold", "7" };
            string expected = $"iron -> 25{Environment.NewLine}coal -> 10{Environment.NewLine}gold -> 7";

            string actual = Program.Miner(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_SingleResource()
        {
            List<string> input = new List<string> { "Copper", "10" };

            string actual = Program.Miner(input);

            Assert.That(actual, Is.EqualTo("copper -> 10"));
        }

        [Test]
        public void Test_SameResources()
        {
            List<string> input = new List<string> { "Iron", "5", "iron", "10", "IRON", "15" };

            string actual = Program.Miner(input);

            Assert.That(actual, Is.EqualTo("iron -> 30"));
        }

        [Test]
        public void Test_InvalidQuantity()
        {
            List<string> input = new List<string> { "Gold", "five" };

            Assert.Throws<FormatException>(() => Program.Miner(input));
        }

        [Test]
        public void Test_MissingQuantity()
        {
            List<string> input = new List<string> { "Gold" };

            Assert.Throws<ArgumentOutOfRangeException>(() => Program.Miner(input));
        }

        [Test]
        public void Test_LargeInput()
        {
            List<string> input = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                input.Add("Gold");
                input.Add("1");
            }
            string result = Program.Miner(input);

            Assert.That(result, Is.EqualTo("gold -> 100"));
        }
    }
}