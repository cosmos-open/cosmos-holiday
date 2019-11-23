using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Martinique.Public;
    using Definitions.NorthAmerica.Martinique.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class MartiniqueHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Martinique;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Martinique;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MqFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MqFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new AbolitionOfSlavery(), //5-22
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MqVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MqVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Martinique",
            };
        }
    }
}