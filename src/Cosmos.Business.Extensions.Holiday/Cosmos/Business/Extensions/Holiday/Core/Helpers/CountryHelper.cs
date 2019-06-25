using System;
using Cosmos.I18N.Countries;
using Cosmos.Joiners;
using Cosmos.Splitters;

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

        public static string FixRegionCode(Country country, string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                throw new ArgumentNullException(nameof(regionCode));

            var checkIndex = regionCode.IndexOf('-');
            string code;

            if (checkIndex < 0)
            {
                code = regionCode.ToUpper();
            }
            else if (checkIndex == 0)
            {
                code = regionCode.Substring(1, regionCode.Length - 1);
            }
            else
            {
                var list = Splitter.On("-").OmitEmptyStrings().TrimResults().SplitToList(regionCode);
                var restList = list.GetRange(1, list.Count - 1);
                code = Joiner.On('-').SkipNulls().Join(restList);
            }

            return $"{EnumsNET.Enums.GetName(country.ToCode()).ToUpper()}-{code.ToUpper()}";
        }

        public static string FixRegionCode(CountryCode code, string regionCode)
        {
            return FixRegionCode(code.ToCountry(), regionCode);
        }
    }
}