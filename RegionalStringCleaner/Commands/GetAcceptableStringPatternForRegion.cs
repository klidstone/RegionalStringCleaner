using RegionalStringCleaner.Models;

namespace RegionalStringCleaner.Commands
{
    public class GetAcceptableStringPatternForRegion
    {
        public string GetAcceptableCharacterPattern(Region region)
        {
            // This function would normally make a database call
            // for the specified region's accepted characters

            // See http://www.europeanpaymentscouncil.eu/index.cfm/knowledge-bank/epc-documents/sepa-requirements-for-an-extended-character-set-unicode-subset-best-practices/
            if (region == Region.Epc)
            {
                return @"^[0-9A-Za-z\(\)\+\,\-\.\/\:\?\ ]*$";
            }

            return "";
        }
    }
}
