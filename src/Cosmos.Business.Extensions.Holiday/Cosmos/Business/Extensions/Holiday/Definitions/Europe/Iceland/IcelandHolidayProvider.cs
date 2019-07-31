using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Iceland.Public;
    using Definitions.Europe.Iceland.Religion;

    /// <summary>
    /// Iceland holiday provider
    /// </summary>
    public class IcelandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Iceland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Iceland;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = IsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> IsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MayDay(), //5-1
            new IcelandicNationalDay(), //6-17
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = IsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> IsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CommerceDay(), //8-1st-monday
            new MaundyThursday(),
            new GoodFriday(),
            new EasterDay(),
            new EasterMonday(),
            new AscensionDay(),
            new WhitSunday(),
            new WhitMonday(),
            new FirstDayOfSummer(), //summer-1st-day
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Iceland",
            };
        }
    }
}