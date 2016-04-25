using RegionalStringCleaner.Models;
using System.Collections.Generic;

namespace RegionalStringCleaner.Repository
{
    public interface IStringCleanerRepository
    {
        Dictionary<char, string> GetCharacterMappingsForRegion(Region region);
        string GetAcceptableStringPatternForRegion(Region region);
    }
}
