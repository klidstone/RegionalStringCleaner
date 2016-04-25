using NUnit.Framework;
using System.Collections.Generic;
using RegionalStringCleaner.Strategies;
using System.Text.RegularExpressions;

namespace RegionalStringCleaner.Tests.RepositoryTests
{
    [TestFixture]
    public class StrategyTests
    {
        private StringCleaner _stringCleaner;
        private Dictionary<char, string> _regionalCharacterMappings = new Dictionary<char, string>
        {
            ['é'] = "e"
        };

        private string _acceptableStringPattern = "^e*$";

        [SetUp]
        public void Init()
        {
            _stringCleaner = new StringCleaner(_regionalCharacterMappings, new Regex(_acceptableStringPattern));
        }

        [Test]
        public void ValidStringRemainsUnchanged()
        {
            var inputString = "e";
            var outputString = _stringCleaner.CleanString(inputString);
            var expectedResult = "e";

            Assert.True(Equals(outputString, expectedResult));
        }

        [Test]
        public void InvalidMappableCharactersAreMapped()
        {
            var inputString = "é";
            var outputString = _stringCleaner.CleanString(inputString);
            var expectedResult = "e";

            Assert.True(Equals(outputString, expectedResult));
        }

        [Test]
        public void InvalidUnmappableCharactersAreDeleted()
        {
            var inputString = "a";
            var outputString = _stringCleaner.CleanString(inputString);
            var expectedResult = "";

            Assert.True(Equals(outputString, expectedResult));
        }

        [Test]
        public void NullStringsRemainNull()
        {
            string inputString = null;
            var outputString = _stringCleaner.CleanString(inputString);

            Assert.IsNull(outputString);
        }
    }
}
