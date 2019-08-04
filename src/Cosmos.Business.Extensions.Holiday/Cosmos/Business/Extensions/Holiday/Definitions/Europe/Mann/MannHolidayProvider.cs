using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Mann.Commemoration;
    using Definitions.Europe.Mann.Public;
    using Definitions.Europe.Mann.Bank;
    using Definitions.Europe.Mann.Religion;

    /// <summary>
    /// United Kingdom holiday provider
    /// </summary>
    public class MannHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Mann;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GbImFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GbImFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new TynwaldDay(), //7-5
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GbImVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GbImVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new SpringBankHoliday(), //5月最后一个周一
            new SeniorRaceDay(), //6-2nd-friday
            new SummerBankHoliday(), //8月最后一个周一
            new EasterMonday(),
            new GoodFriday()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Isle_of_Man",
            };
        }
    }
}