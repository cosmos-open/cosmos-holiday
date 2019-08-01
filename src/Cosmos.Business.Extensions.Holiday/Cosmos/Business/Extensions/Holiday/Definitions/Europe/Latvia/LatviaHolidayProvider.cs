using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Latvia.Commemoration;
    using Definitions.Europe.Latvia.Public;
    using Definitions.Europe.Latvia.Religion;

    /// <summary>
    /// Latvia holiday provider
    /// </summary>
    public class LatviaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Latvia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Latvia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = LvFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> LvFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new IndependenceDay(), //5-4
            new MidsummerEve(), //6-23
            new MidsummerDay(), //6-24
            new ProclamationDay(), //11-18
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = LvVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> LvVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new MothersDay(), //5-2nd-sunday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Latvia"
            };
        }
    }
}