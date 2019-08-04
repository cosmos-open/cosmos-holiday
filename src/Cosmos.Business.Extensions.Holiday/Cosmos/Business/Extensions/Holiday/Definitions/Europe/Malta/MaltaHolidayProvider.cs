using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Malta.Commemoration;
    using Definitions.Europe.Malta.Public;
    using Definitions.Europe.Malta.Religion;

    /// <summary>
    /// Malta holiday provider
    /// </summary>
    public class MaltaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Malta;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Malta;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MkFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MkFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new FeastOfStPaulsShipwreck(), //2-10
            new StJoseph(), //3-19
            new FreedomDay(), //3-31
            new WorkersDay(), //5-1
            new SetteGiugno(), //6-7
            new FeastOfStPeterAndStPaul(), //6-29
            new AssumptionDay(), //8-15
            new FeastOfOurLadyOfVictories(), //9-8
            new IndependenceDay(), //9-21
            new ImmaculateConception(), //12-8
            new RepublicDay(), //12-13
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MkVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MkVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Malta"
            };
        }
    }
}