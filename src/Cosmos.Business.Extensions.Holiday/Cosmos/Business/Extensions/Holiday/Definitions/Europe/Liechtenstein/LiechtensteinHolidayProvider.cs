using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Liechtenstein.Commemoration;
    using Definitions.Europe.Liechtenstein.Public;
    using Definitions.Europe.Liechtenstein.Religion;
    using Definitions.Europe.Liechtenstein.Tradition;

    /// <summary>
    /// Liechtenstein holiday provider
    /// </summary>
    public class LiechtensteinHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Liechtenstein;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Liechtenstein;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = LiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> LiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new StBerchtoldsDay(), //1-2
            new Epiphany(), //1-6
            new Candlemas(), //2-2
            new SaintJosephsDay(), //3-19
            new LabourDay(), //5-1
            new Ascension(), //5-29
            new NationalHoliday(), //8-15
            new NativityOfOurLady(), //9-8
            new AllSaintsDay(), //11-1
            new ImmaculateConception(), //12-8
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = LiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> LiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterMonday(),
            new WhitMonday(),
            new CorpusChristi(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Liechtenstein"
            };
        }
    }
}