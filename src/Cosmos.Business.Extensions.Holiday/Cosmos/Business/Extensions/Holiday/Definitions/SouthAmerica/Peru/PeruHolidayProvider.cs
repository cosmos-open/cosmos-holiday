using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Peru.Commemoration;
    using Definitions.SouthAmerica.Peru.Public;
    using Definitions.SouthAmerica.Peru.Religion;
    using Definitions.SouthAmerica.Peru.Tradition;

    /// <summary>
    /// Peru holiday provider
    /// </summary>
    public class PeruHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Peru;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new InternationalWorkersDay(), //5-1
            new StPeterAndStPaul(), //6-29
            new IndependenceDay(), //5-14 ~ 5-15
            new IndependenceDay(), //7-28 ~ 7-29
            new SantaRosaDeLima(), //8-30
            new BattleOfAngamos(), //10-8
            new AllSaintsDay(), //11-1
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new HolyThursday(),
            new GoodFriday(),
            new EasterDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Peru"
            };
        }
    }
}