using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Slovakia.Commemoration;
    using Definitions.Europe.Slovakia.Public;
    using Definitions.Europe.Slovakia.Religion;

    /// <summary>
    /// Slovakia holiday provider
    /// </summary>
    public class SlovakiaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Slovakia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SkFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SkFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new EstablishmentDay(), //1-1
            new Epiphany(), //1-6
            new InternationalWorkersDay(), //5-1
            new DayOfVictoryOverFascism(), //5-8
            new StCyrilAndMethodiusDay(), //7-5
            new Constitution(), //9-1
            new UprisingAnniversary(), //8-29
            new Lady(), //9-15
            new FreedomAndDemocracyDay(), //11-17
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SkVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SkVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11-1st-monday
            new EasterMonday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Slovakia"
            };
        }
    }
}