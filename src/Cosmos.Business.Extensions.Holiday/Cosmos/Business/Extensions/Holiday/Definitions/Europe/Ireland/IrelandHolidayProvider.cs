using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Ireland.Commemoration;
    using Definitions.Europe.Ireland.Public;
    using Definitions.Europe.Ireland.Religion;

    /// <summary>
    /// Ireland holiday provider
    /// </summary>
    public class IrelandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Ireland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Ireland;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = IeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> IeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new SaintPatricksDay(), //3-17
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = IeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> IeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MayDay(), //5-1st-monday
            new JuneHoliday(), //7-1st-monday
            new AugustHoliday(), //8-1st-monday
            new OctoberHoliday(), //10-last-monday
            new EasterMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Republic_of_Ireland",
            };
        }
    }
}