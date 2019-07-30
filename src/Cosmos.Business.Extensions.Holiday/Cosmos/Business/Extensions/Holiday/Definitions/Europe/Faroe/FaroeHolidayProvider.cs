using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Faroe.Commemoration;
    using Definitions.Europe.Faroe.Public;
    using Definitions.Europe.Faroe.Religion;

    /// <summary>
    /// Faroe holiday provider
    /// </summary>
    public class FaroeHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Faroe;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Faroe;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Does this provider include special type of regions?
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public override bool DoesIncludeRegion(string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;

            regionCode = CountryHelper.FixRegionCode(Country.Finland, regionCode);

            switch (regionCode)
            {
                case "DK-FO":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.FO);
                default:
                    return base.DoesIncludeRegion(regionCode);
            }
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = FoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> FoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NationalFlagDay(), //4-25
            new ConstitutionDay(), //6-5
            new SaintOlavsEve(), //7-28
            new SaintOlavsDay(), //7-29
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = FoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> FoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MaundyThursday(),
            new EasterSunday(),
            new EasterMonday(),
            new GoodFriday(),
            new GeneralPrayerDay(),
            new AscensionDay(),
            new Pentecost(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Faroe_Islands",
            };
        }
    }
}