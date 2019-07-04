using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Sweden.Commemoration;
    using Definitions.Europe.Sweden.Public;
    using Definitions.Europe.Sweden.Religion;

    /// <summary>
    /// Sweden holiday provider
    /// </summary>
    public class SwedenHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Sweden;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Sweden;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new InternationalWorkersDay(), //5-1
            new NationalDay(), //6-6
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MidsummerDay(),//6-3rd-staurday
            new AllSaintsDay(), //11-1st-monday
            new AscensionDay(),
            new EasterMonday(),
            new EasterSunday(),
            new GoodFriday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Sweden"
            };
        }
    }
}