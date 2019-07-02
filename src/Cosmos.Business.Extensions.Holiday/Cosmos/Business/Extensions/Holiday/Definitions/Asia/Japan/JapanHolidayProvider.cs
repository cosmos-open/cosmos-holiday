using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Japan.Bank;
    using Definitions.Asia.Japan.Commemoration;
    using Definitions.Asia.Japan.Public;

    /// <summary>
    /// Japan holiday provider
    /// </summary>
    public class JapanHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Japan;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Japan;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = JpFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> JpFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new 銀行休業日(), //1-2 ~ 1-3
            new ComingOfAgeDay2000b(), //1-15
            new SevenFiveThreeFestival(), //11-15
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = JpVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> JpVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ComingOfAgeDay(), //1月的第二个周一
            new FoundationDay(), //2-11
            new ShowaDay(), //4-29
            new MemorialDay(), //5-3
            new GreeneryDay(), //5-4
            new ChildrensDay(), //5-5
            new MarineDay(), //7月的第三个周一
            new MountainDay(), //8-11
            new RespectForTheAgedDay(), //9月的第三个周一
            new HealthAndSportsDay(), //10-2
            new CultureDay(), //11-3
            new LabourThanksgivingDay(), //11-23
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Japan",
                "https://en.wikipedia.org/wiki/Golden_Week_(Japan)",
                "https://www.boj.or.jp/en/about/outline/holi.htm/"
            };
        }
    }
}