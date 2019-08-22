using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Guatemala.Public;
    using Definitions.NorthAmerica.Guatemala.Religion;
    using Definitions.NorthAmerica.Guatemala.Tradition;

    /// <summary>
    /// Guatemala Holiday Provider
    /// </summary>
    public class GuatemalaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Guatemala;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GtFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GtFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new InternationalWorkersDay(), //5-1
            new ArmyDay(), //6-30
            new IndependenceDay(), //9-15
            new RevolutionDay(), //10-20
            new AllSaintsDay(), //11-1
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new NewYearsEve(), //12-31
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GtVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GtVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MaundyThursday(),
            new GoodFriday(),
            new HolySaturday(),
            new EasterSunday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Guatemala",
            };
        }
    }
}