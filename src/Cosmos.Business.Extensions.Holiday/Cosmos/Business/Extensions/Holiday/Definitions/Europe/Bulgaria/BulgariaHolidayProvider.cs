using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Bulgaria.Commemoration;
    using Definitions.Europe.Bulgaria.Public;
    using Definitions.Europe.Bulgaria.Religion;

    /// <summary>
    /// Bulgaria holiday provider
    /// </summary>
    public class BulgariaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BulgariaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bulgaria;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LiberationDay(), //3-3
            new InternationalWorkersDay(), //5-1
            new SaintGeorgesDay(), //5-6
            new SaintsCyrilAndMethodiusDay(), //5-24
            new UnificationDay(), //9-6
            new IndependenceDay(), //9-22
            new NationalAwakeningDay(), //11-1
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bulgaria",
            };
        }
    }
}