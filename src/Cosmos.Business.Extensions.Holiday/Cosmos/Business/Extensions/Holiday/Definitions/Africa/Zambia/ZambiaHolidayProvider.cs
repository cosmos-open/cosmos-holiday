using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Zambia.Commemoration;
    using Definitions.Africa.Zambia.Public;
    using Definitions.Africa.Zambia.Religion;

    /// <summary>
    /// Zambia holiday provider
    /// </summary>
    public class ZambiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Zambia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Zambia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ZmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ZmFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new WomensDay(), //3-9
            new YouthDay(), //3-12
            new LabourDay(), //5-1
            new AfricanFreedomDay(), //5-25
            new NationalDayOfPrayers2018(), //only 2018-10-18
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ZmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ZmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new HeroesDay(), //7-1st-monday
            new UnityDay(), //day after 7-1st-monday
            new FarmersDay(), //8-st-monday
            new GoodFriday(),
            new HolySaturday(),
            new IndependenceDay(), //4-18
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Zambia",
                "http://www.parliament.gov.zm/sites/default/files/documents/acts/Public%20Holidays%20Act.pdf"
            };
        }
    }
}