using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Italy.Tradition;
    using Definitions.Europe.Italy.Public;
    using Definitions.Europe.Italy.Religion;

    /// <summary>
    /// Italy holiday provider
    /// </summary>
    public class ItalyHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Italy;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Italy;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ItFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ItFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new LiberationDay(), //4-25
            new InternationalWorkersDay(), //5-1
            new RepublicDay(), //6-2
            new AssumptionDay(), //8-15
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ItVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ItVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11-1
            new EasterMonday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Italy",
            };
        }
    }
}