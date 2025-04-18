using System;
using Task71_VowelsCount;
using NUnit.Framework;

namespace VowelsCountTests
{
    public class Tests
    {
        [Test]
        public void Test_VowelsCount()
        {
            string input = "Manfred Albrecht Freiherr von Richthofen, known in English as Baron von Richthofen was a fighter pilot with the German Air Force during World War I.";

            string expected = "41";
            
            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_NoVowels()
        {
            string input = "Mnfd lbrcht Frhrr vn Rchthfn, knwn n nglsh s Brn vn Rchthfn ws fghtr plt wth th Grmn r Frc drng Wrld Wr.";

            string expected = "0";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_OnlyVowels()
        {
            string input = "aaaa iiiii uuu eee aeoui";

            string expected = "20";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_CaseInsensitive()
        {
            string input = "EOUIAEOIUA fwioiioac PPP OIHdseertJnMOLoouTytyb";

            string expected = "24";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SingleVowel()
        {
            string input = "E";

            string expected = "1";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_EmptyString()
        {
            string input = "";

            string expected = "0";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_NumberAndSpecialCharacters()
        {
            string input = "!£$%Ee&)( Go gO g0 12345A";

            string expected = "5";

            string actual = Program.VowelsCount(input);

            Assert.AreEqual(expected, actual);
        }
    }
}