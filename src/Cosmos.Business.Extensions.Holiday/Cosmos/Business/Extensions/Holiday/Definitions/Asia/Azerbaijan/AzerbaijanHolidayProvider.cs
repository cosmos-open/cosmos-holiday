using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Azerbaijan.Religion;
    using Definitions.Asia.Azerbaijan.Commemoration;
    using Definitions.Asia.Azerbaijan.Public;
    using Definitions.Asia.Azerbaijan.Tradition;

    /// <summary>
    /// Azerbaijan holiday provider
    /// </summary>
    public class AzerbaijanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Azerbaijan;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Azerbaijan;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MartyrsDay(), //1-20
            new WomensDay(), //3-8
            new SpringFestival(), //3-20
            new ConstitutionDay(), //11-12
            new NationalRevivalDay(),//11-17
            new InternationalSolidarityDay(),//12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Victory(), //5-9
            new RepublicDay(), //5-28
            new NationalSalvationDay(), //6-15
            new AzerbaijanArmedForcesDay(),//6-26
            new IndependenceDay(), //10-18
            new FlagDay(),//11-9
            new EndOfRamadan(),//shawwal 1 ~ Shawwal 2
            new FeastOfTheSacrifice(),//Dhu al-Hijiah 10 ~ Dhu al-Hijiah 11
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.president.az/pages/7/print"
            };
        }
    }
}