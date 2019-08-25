using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Bolivia.Commemoration;
    using Definitions.SouthAmerica.Bolivia.Public;
    using Definitions.SouthAmerica.Bolivia.Religion;
    using Definitions.SouthAmerica.Bolivia.Tradition;

    /// <summary>
    /// Bolivia holiday provider
    /// </summary>
    public class BoliviaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BoliviaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bolivia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new FeastOfTheVirginOfCandelaria(), //2-2
            new LabourDay(), //5-1
            new AndeanNewYear(), //6-21
            new AgrarianReformDay(), //8-2
            new IndependenceDay(), //8-6
            new AllSaintsDay(), //11-2
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new CorpusChristi(),
            new Carnival(),
            new Carnival48(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bolivia"
            };
        }
    }
}