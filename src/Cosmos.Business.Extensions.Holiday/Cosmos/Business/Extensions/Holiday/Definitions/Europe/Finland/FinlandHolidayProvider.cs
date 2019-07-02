using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Finland.Public;
    using Definitions.Europe.Finland.Religion;

    /// <summary>
    /// Finland holiday provider
    /// </summary>
    public class FinlandHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = FinlandRegions.GetMainRegionCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Finland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Finland;

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
                case "FI-01":
                case "FI-AX":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.AX);
                default:
                    return base.DoesIncludeRegion(regionCode);
            }
        }

        /// <summary>
        /// Fix region code
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public override string FixRegionCode(string regionCode)
        {
            switch (regionCode)
            {
                case "01":
                    return "AX";

                case "FI-01":
                    return "FI-AX";

                default:
                    return regionCode;
            }
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = FiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> FiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MayDay(), //5-1
            new Epiphany(), //6-1
            new IndependenceDay(), //12-6
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = FiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> FiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MidsummerEve(), //6月第三个周五
            new MidsummerDay(), //6月第三个周六
            new AllSaintsDay(), //11月第一个周六
            new EasterSunday(),
            new EasterMonday(),
            new AscensionDay(),
            new GoodFriday(),
            new Pentecost(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Finland",
            };
        }
    }
}