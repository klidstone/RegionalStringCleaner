using RegionalStringCleaner.Models;
using System.Collections.Generic;

namespace RegionalStringCleaner.Repository
{
    public class StringCleanerRepository : IStringCleanerRepository
    {
        private readonly Commands.GetAcceptableStringPatternForRegion _acceptableStringPatternForRegion;
        private readonly Commands.GetCharacterMappingsForRegion _characterMappingsForRegion;

        public StringCleanerRepository()
        {
            _acceptableStringPatternForRegion = new Commands.GetAcceptableStringPatternForRegion();
            _characterMappingsForRegion = new Commands.GetCharacterMappingsForRegion();
        }

        public Dictionary<char, string> GetCharacterMappingsForRegion(Region region)
        {
            return _characterMappingsForRegion.CharacterMappings(region);
        }

        public string GetAcceptableStringPatternForRegion(Region region)
        {
            return _acceptableStringPatternForRegion.GetAcceptableCharacterPattern(region);
        }
    }
}
