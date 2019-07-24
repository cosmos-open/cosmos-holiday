using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Mozambique.Commemoration;
    using Definitions.Africa.Mozambique.Public;
    using Definitions.Africa.Mozambique.Religion;

    /// <summary>
    /// Mozambique holiday provider
    /// </summary>
    public class MozambiqueHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Mozambique;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Mozambique;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new HeroesDay(), //2-3
            new WomensDay(), //4-7
            new WorkersDay(), //5-1
            new IndependenceDay(), //6-25
            new VictoryDay(), //9-7
            new RevolutionDay(), //9-25
            new DayOfPeaceAndReconciliation(), //10-4
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MzVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Mozambique",
                "http://www.dniwolne.eu/zn-%E9%9D%9E%E6%B4%B2-%E5%81%87%E6%9C%9F-%E8%8E%AB%E6%A1%91%E6%AF%94%E5%85%8B.html"
            };
        }
    }
}