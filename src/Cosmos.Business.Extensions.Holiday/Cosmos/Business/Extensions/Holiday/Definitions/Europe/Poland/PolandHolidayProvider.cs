using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Poland.Commemoration;
    using Definitions.Europe.Poland.Public;
    using Definitions.Europe.Poland.Religion;
    using Definitions.Europe.Poland.Tradition;

    /// <summary>
    /// Poland holiday provider
    /// </summary>
    public class PolandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Poland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PlFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PlFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new MayDay(), //5-1
            new ConstitutionDay(), //5-3
            new ConstitutionDay(), //5-17
            new AssumptionDay(), //8-15
            new IndependenceDay(), //11-11
            new IndependenceDay2018(), //11-11
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PlVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PlVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11-1st-monday
            new EasterMonday(),
            new EasterDay(),
            new CorpusChristi(),
            new PentecostSunday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Poland"
            };
        }
    }
}