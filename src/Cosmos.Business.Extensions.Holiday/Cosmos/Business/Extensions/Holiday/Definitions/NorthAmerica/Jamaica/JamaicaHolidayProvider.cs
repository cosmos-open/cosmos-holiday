using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Jamaica.Public;
    using Definitions.NorthAmerica.Jamaica.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class JamaicaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Jamaica;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = JmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> JmFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-23
            new EmancipationDay(), //8-1
            new NationalHeroesDay(), //10-16
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = JmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> JmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AshWednesday(),
            new GoodFriday(),
            new EasterMonday(),
            new IndependenceDay(), //8-6
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Jamaica",
            };
        }
    }
}