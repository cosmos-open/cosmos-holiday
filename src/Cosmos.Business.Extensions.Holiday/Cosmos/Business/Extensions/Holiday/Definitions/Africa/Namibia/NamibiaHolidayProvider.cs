using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Namibia.Commemoration;
    using Definitions.Africa.Namibia.Public;
    using Definitions.Africa.Namibia.Religion;

    /// <summary>
    /// Namibia holiday provider
    /// </summary>
    public class NamibiaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Namibia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Namibia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new IndependenceDay(), //3-21
            new WorkersDay(), //5-1
            new CassingaDay(), //5-4
            new AfricaDay(), //5-25
            new HumanRightsDay(), //12-10
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new GoodFriday(),
            new AscensionDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Namibia"
            };
        }
    }
}