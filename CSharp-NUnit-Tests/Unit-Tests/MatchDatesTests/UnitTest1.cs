using Task36_MatchDates;

namespace MatchDatesTests
{
    public class Tests
    {
        [Test]
        public void Test_ValidDate()
        {
            string dates = "31.Dec.2022";

            string expected = "Day: 31, Month: Dec, Year: 2022";
            string actual = Program.Match(dates);
            
            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_NoMatch()
        {
            string dates = "31-Dec.2020 01.Jan/2002 20/Apr-1999 11/Jun.2025";
            string expected = "No valid date found";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_MultipleMatches()
        {
            string dates = "31-Dec-2020 01/Jan/2002 20.Apr.1999 11-Jun-2025";
            string expected =
    $"Day: 31, Month: Dec, Year: 2020\n" +
    $"Day: 01, Month: Jan, Year: 2002\n" +
    $"Day: 20, Month: Apr, Year: 1999\n" +
    $"Day: 11, Month: Jun, Year: 2025";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_EmptyString()
        {
            string dates = string.Empty;

            Assert.Throws<ArgumentException>(() => Program.Match(dates));
        }

        [Test]
        public void Test_NullInput()
        {
            string dates = null;

            Assert.Throws<ArgumentException>(() => Program.Match(dates));
        }
        [Test]
        public void Test_MixedData()
        {
            string dates = "31-Dec-2020 01/Jan/2002 31-Dec.2020 01.Jan/2002 20/Apr-1999 11/Jun.2025 20.Apr.1999 11-Jun-2025";
            string expected =
    $"Day: 31, Month: Dec, Year: 2020\n" +
    $"Day: 01, Month: Jan, Year: 2002\n" +
    $"Day: 20, Month: Apr, Year: 1999\n" +
    $"Day: 11, Month: Jun, Year: 2025";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_InvalidInput()
        {
            string dates = "This is test";
            string expected = "No valid date found";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_ValidDateInText()
        {
            string dates = "Today is 01-May-2025";
            string expected = "Day: 01, Month: May, Year: 2025";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_LowercaseMonth()
        {
            string dates = "31-dec-2020";
            string expected = "No valid date found";

            string actual = Program.Match(dates);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}