using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Vatican.Religion;

    /// <summary>
    /// Vatican holiday provider
    /// </summary>
    public class VaticanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Vatican;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Vatican;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = VaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> VaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new Solemnity_1_1(), //1-1
            new Epiphany(), //1-6
            new AnniversaryOfTheFoundation(), //2-11
            new AnniversaryOfTheElection(), //3-13
            new SaintJosephsDay(), //3-19
            new SaintGeorge(), //4-23
            new SaintJosephTheWorker(), //5-1
            new SaintsPeterAndPaul(), //6-29
            new AssumptionDay(), //8-15
            new NativityOfMary(), //9-8
            new AllSaints(), //11-1
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = VaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> VaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Vatican_City"
            };
        }
    }
}