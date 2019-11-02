using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.ChristmasIsland.Commemoration;
    using Definitions.Asia.ChristmasIsland.Public;
    using Definitions.Asia.ChristmasIsland.Religion;

    /// <summary>
    /// ChristmasIsland holiday provider
    /// </summary>
    public class ChristmasIslandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.ChristmasIsland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CxFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CxFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(),//3-20
            new AnzacDay(),//4-25
            new TerritoryDay(),//10-6
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CxVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CxVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AustraliaDay(),//1-26
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
            new EidAlFitrEndOfRamadan(), //1-shawwal
            new DayOfTheSacrifice(), // 10 Dhu al-Hijjah
            new ChineseNewYear(),
            new GoodFriday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Christmas_Island"
            };
        }
    }
}