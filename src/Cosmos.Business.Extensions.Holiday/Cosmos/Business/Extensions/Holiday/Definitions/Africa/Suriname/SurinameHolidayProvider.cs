using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Suriname.Commemoration;
    using Definitions.Africa.Suriname.Public;
    using Definitions.Africa.Suriname.Religion;

    /// <summary>
    /// Suriname holiday provider
    /// </summary>
    public class SurinameHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SurinameRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Suriname;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Suriname;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ThreeKingsDay(), //1-6
            new DayOfTheRevolution(), //2-25
            new LabourDay(), //5-1
            new AscensionDay(), //5-25
            new IndianArrivalDay(), //6-5
            new KetiKoti(), //7-1
            new JavaneseArrivalDay(), //8-8
            new IndigenousPeoplesDay(), //8-9
            new DayOfTheMaroons(), //10-10
            new ChineseArrivalDay(), //10-20
            new IndependenceDay(), //11-25
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new WorldReligionDay(), //1-3rd-sunday
            new GoodFriday(),
            new EasterSunday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Suriname#National_holidays"
            };
        }
    }
}