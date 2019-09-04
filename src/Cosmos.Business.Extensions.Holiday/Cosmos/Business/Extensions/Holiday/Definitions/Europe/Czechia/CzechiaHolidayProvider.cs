using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Czechia.Commemoration;
    using Definitions.Europe.Czechia.Public;
    using Definitions.Europe.Czechia.Religion;
    using Definitions.Europe.Czechia.Tradition;

    /// <summary>
    /// Czechia holiday provider
    /// </summary>
    public class CzechiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Czechia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new EstablishmentDay(), //1-1
            new LabourDay(), //5-1
            new LiberationDay(), //5-8
            new StCyrilAndMethodiusDay(), //7-5
            new JanHusDay(), //7-6
            new StWenceslasDay(), //9-28
            new CzechStatehoodDay(), //9-28
            new IndependentCzechoslovakStateDay(), //10-28
            new NationalizationDay(), //10-28
            new AllSaintsDay(), //11-1
            new FreedomDemocracyDay(), //11-17
            new ImmaculateConception(), //12-8
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Czech_Republic"
            };
        }
    }
}