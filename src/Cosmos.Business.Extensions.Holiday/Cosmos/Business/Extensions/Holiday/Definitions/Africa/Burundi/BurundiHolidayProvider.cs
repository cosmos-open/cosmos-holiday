using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Burundi.Commemoration;
    using Definitions.Africa.Burundi.Public;
    using Definitions.Africa.Burundi.Religion;
    using Definitions.Africa.Burundi.Tradition;

    /// <summary>
    /// Burundi holiday provider
    /// </summary>
    public class BurundiHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BurundiRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Burundi;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new UnityDay(), //2-5
            new NtaryamiraDay(), //4-6
            new LabourDay(), //5-1
            new AscensionDay(), //5-25
            new IndependenceDay(), //7-1
            new AssumptionDay(), //8-15
            new RwagasoreDay(), //10-13
            new NdadayeDay(), //10-21
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EndOfRamadan(), //1-shawwal
            new FeastOfTheSacrifice(), //10-Dhu al-Hijjah
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://fr.wikipedia.org/wiki/Burundi",
                "http://www.burundi.gov.bi/IMG/pdf/decret_211.pdf"
            };
        }
    }
}