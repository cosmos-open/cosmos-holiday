using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class CountryHelper
    {
        public static string GetRegionCode(Country country, Country belongsToCountry)
        {
            if (country == belongsToCountry)
                return EnumsNET.Enums.GetName(country.ToCode());
            return $"{EnumsNET.Enums.GetName(belongsToCountry.ToCode()).ToUpper()}-{EnumsNET.Enums.GetName(country.ToCode()).ToUpper()}";
        }
    }
}