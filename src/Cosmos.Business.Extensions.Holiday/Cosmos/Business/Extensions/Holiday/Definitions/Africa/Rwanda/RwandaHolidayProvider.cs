using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Rwanda.Public;
    using Definitions.Africa.Rwanda.Religion;

    /// <summary>
    /// Rwanda holiday provider
    /// </summary>
    public class RwandaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Rwanda;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.France;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = RwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> RwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new HeroesDay(),//2-1
            new GenocideMemorialDay(),//4-7
            new LabourDay(),//5-1
            new IndependenceDay(),//7-1
            new LiberationDay(),//7-4
            new Assumption(),//8-15
            new ChristmasDay(),//12-25
            new BoxingDay(),//12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = RwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> RwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new NationalHarvestDay(),//8-1st-friday
            new EndOfRamadan(),
            new FeastOfTheSacrifice()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.rw/home/official_holidays/"
            };
        }
    }
}