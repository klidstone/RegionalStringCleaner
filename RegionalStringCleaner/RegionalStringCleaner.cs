using RegionalStringCleaner.Models;
using RegionalStringCleaner.Repository;
using RegionalStringCleaner.Strategies;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegionalStringCleaner
{
    public class RegionalStringCleaner
    {
        private readonly StringCleaner _stringCleaner;

        public RegionalStringCleaner(Region region)
        {
            var repository = new StringCleanerRepository();
            var regionalCharacterMappings = repository.GetCharacterMappingsForRegion(region);
            var regionalAcceptableCharacters = new Regex(repository.GetAcceptableStringPatternForRegion(region), RegexOptions.Compiled);

            _stringCleaner = new StringCleaner(regionalCharacterMappings, regionalAcceptableCharacters);
        }

        public string CleanString(string inputString)
        {
            return _stringCleaner.CleanString(inputString);
        }
    }
}
