using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Honduras.Commemoration;
    using Definitions.SouthAmerica.Honduras.Public;
    using Definitions.SouthAmerica.Honduras.Religion;

    /// <summary>
    /// Honduras holiday provider
    /// </summary>
    public class HondurasHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Honduras;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Honduras;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = HnFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> HnFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new AmericasDay(), //4-14
            new LabourDay(), //5-1
            new IndependenceDay(), //9-15
            new SoldiersDay(), //10-3
            new FranciscoMorazánsDay(), //10-3
            new ColumbusDay(), //10-12
            new ArmyDay(), //10-21
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = HnVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> HnVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new HolyThursday(),
            new GoodFriday(),
            new HolySaturday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Honduras",
            };
        }
    }
}