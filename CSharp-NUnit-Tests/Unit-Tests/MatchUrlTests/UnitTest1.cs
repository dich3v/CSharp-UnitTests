using Task81_MatchUrl;

namespace MatchUrlTests
{
    public class Tests
    {
        [Test]
        public void Test_EmptyText()
        {
            string text = "";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.Empty);
        }
        [Test]
        public void Test_NoUrlsInText()
        {
            string text = "This is test";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.Empty);
        }

        [Test]
        public void Test_SingleUrlInText()
        {
            string text = "Go to http://www.test-site.org for details";
            string expected = "http://www.test-site.org";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_UrlsWithQueryParameters()
        {
            string text = "Visit https://example.com/search?q=test&sort=asc for results.";
            string expected = "https://example.com";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_MultipleUrlsInText()
        {
            string text = "Resources: https://openai.com and https://github.com";
            string expected = "https://openai.com https://github.com";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_UrlsInQuotationMarks()
        {
            string text = "Click on \"https://example.com\" or 'http://test.org' to proceed";
            string expected = "https://example.com http://test.org";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_MixedValidAndInvalidUrls()
        {
            string text = "Try https://valid.com and this: htp://invalid.com or www.missing-scheme.com";
            string expected = "https://valid.com";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_DuplicateUrls()
        {
            string text = "Link: https://repeat.com and again https://repeat.com";
            string expected = "https://repeat.com https://repeat.com";

            string actual = Program.ExtractUrls(text);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}