using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegionalStringCleaner.Strategies
{
    public class StringCleaner : IStringCleaner
    {
        private readonly Dictionary<char, string> _regionalCharacterMappings;
        private readonly Regex _regionalAcceptableCharacters;

        public StringCleaner(Dictionary<char, string> regionalCharacterMappings, Regex regionalAcceptableCharacters)
        {
            _regionalCharacterMappings = regionalCharacterMappings;
            _regionalAcceptableCharacters = regionalAcceptableCharacters;
        }

        public string CleanString(string inputString)
        {
            if (inputString == null)
            {
                return null;
            }

            if (StringMatchesAcceptablePattern(inputString))
            {
                return inputString;
            }

            return ReplaceBadCharacters(inputString);
        }

        private bool StringMatchesAcceptablePattern(string inputString)
        {
            return _regionalAcceptableCharacters.IsMatch(inputString);
        }

        private string ReplaceBadCharacters(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var currentChar in inputString)
            {
                if (_regionalAcceptableCharacters.IsMatch(currentChar.ToString()))
                {
                    stringBuilder.Append(currentChar);
                    continue;
                }

                if (_regionalCharacterMappings.Keys.Contains(currentChar))
                {
                    stringBuilder.Append(_regionalCharacterMappings[currentChar]);
                    continue;
                }
            }

            return stringBuilder.ToString();
        }
    }
}
