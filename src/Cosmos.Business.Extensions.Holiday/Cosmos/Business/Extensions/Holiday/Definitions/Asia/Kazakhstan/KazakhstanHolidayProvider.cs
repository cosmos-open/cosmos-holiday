using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Kazakhstan.Religion;
    using Definitions.Asia.Kazakhstan.Commemoration;
    using Definitions.Asia.Kazakhstan.Public;

    /// <summary>
    /// Kazakhstan holiday provider
    /// </summary>
    public class KazakhstanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Kazakhstan;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = KzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> KzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NewYearsDay2(), //1-2
            new NationUnityDay(), //1-5
            new WomensDay(), //3-8
            new Nauryz(), //3-21
            new HomelandProtectorDay(), //5-7
            new VictoryDay(), //5-9
            new CapitalDay(), //7-6
            new ConstitutionDay(), //8-30
            new KurbanAitDay(), //9-1
            new FirstPresidentDay(), //12-1
            new IndependenceDay(), //12-16
            new Christmas(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = KzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> KzVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Kazakhstan",
                "https://en.wikipedia.org/wiki/Golden_Week_(Kazakhstan)",
                "https://www.boj.or.jp/en/about/outline/holi.htm/"
            };
        }
    }
}