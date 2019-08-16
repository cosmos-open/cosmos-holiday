using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Netherlands.Public;
    using Definitions.Europe.Netherlands.Religion;

    /// <summary>
    /// Netherlands holiday provider
    /// </summary>
    public class NetherlandsHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Netherlands;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NlFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NlFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LiberationDay(), //5-5
            new LiberationDay4590(), //5-5
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NlVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NlVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new KingsDay(), //4-27
            new AscensionDay(),
            new GoodFriday(),
            new EasterMonday(),
            new EasterSunday(),
            new AscensionDay(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Netherlands"
            };
        }
    }
}