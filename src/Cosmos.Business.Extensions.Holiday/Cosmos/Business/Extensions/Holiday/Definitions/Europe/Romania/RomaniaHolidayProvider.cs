using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Romania.Commemoration;
    using Definitions.Europe.Romania.Public;
    using Definitions.Europe.Romania.Religion;

    /// <summary>
    /// Romania holiday provider
    /// </summary>
    public class RomaniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Romania;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Romania;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = RoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> RoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NewYearsDayAfter(), //1-2    
            new UnionDay(), //1-24
            new LabourDay(), //5-1
            new ChildrensDay(), //6-1
            new DormitionOfTheTheotokos(), //8-15
            new StAndrewsDay(), //11-30
            new NationalDay(), //12-1    
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = RoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> RoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new EasterSunday(),
            new GoodFriday(),
            new WhitMonday(),
            new PentecostDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Romania"
            };
        }
    }
}