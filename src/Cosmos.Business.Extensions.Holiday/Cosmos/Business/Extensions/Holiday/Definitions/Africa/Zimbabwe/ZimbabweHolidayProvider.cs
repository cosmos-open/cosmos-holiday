using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Zimbabwe.Commemoration;
    using Definitions.Africa.Zimbabwe.Public;
    using Definitions.Africa.Zimbabwe.Religion;

    /// <summary>
    /// Zimbabwe holiday provider
    /// </summary>
    public class ZimbabweHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Zimbabwe;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Zimbabwe;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ZwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ZwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new YouthDay(), //2-21
            new IndependenceDay(), //4-18
            new WorkersDay(), //5-1
            new AfricaDay(), //5-25
            new UnityDay(),//12-22
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ZwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ZwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new HeroesDay(),
            new DefenceForcesDay(),
            new GoodFriday(),
            new EasterSaturday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Zimbabwe"
            };
        }
    }
}