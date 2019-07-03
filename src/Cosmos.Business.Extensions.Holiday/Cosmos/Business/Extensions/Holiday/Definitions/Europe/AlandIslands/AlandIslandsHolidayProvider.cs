using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.AlandIslands.Public;
    using Definitions.Europe.AlandIslands.Religion;

    /// <summary>
    /// AlandIslands holiday provider
    /// </summary>
    public class AlandIslandsHolidayProvider : BaseDefinitionRegister
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.AlandIslands;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions()
        {
            return new[] {CountryHelper.GetRegionCode(Country, BelongsToCountry)};
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AxFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AxFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new DemilitarizationDay(), //3-30
            new WalpurgisNight(), //4-30
            new MayDay(), //5-1
            new AutonomyDay(), //6-9
            new IndependenceDay(), //12-6
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AxVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AxVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MidsummerEve(), //6月第三个周五
            new MidsummerDay(), //6月第三个周六
            new AllSaintsDay(), //11月第一个周六
            new EasterSunday(),
            new EasterMonday(),
            new AscensionDay(),
            new GoodFriday(),
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
                "https://de.wikipedia.org/wiki/%C3%85land"
            };
        }
    }
}