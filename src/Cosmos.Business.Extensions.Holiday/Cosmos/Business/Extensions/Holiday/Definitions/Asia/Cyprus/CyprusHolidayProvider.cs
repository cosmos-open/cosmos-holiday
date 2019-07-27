using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Cyprus.Commemoration;
    using Definitions.Asia.Cyprus.Public;
    using Definitions.Asia.Cyprus.Religion;

    /// <summary>
    /// Cyprus holiday provider
    /// </summary>
    public class CyprusHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CyprusRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Cyprus;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Cyprus;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CyFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CyFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(),
            new CyprusNationalDay(), //4-1
            new LabourDay(), //5-1
            new DormitionOfTheTheotokos(), //8-15
            new IndependenceDay(), //10-1
            new GreekNationalDay(), //10-28
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CyVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CyVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CleanMonday(),
            new GoodFriday(),
            new EasterMonday(),
            new EasterTuesday(),
            new Pentecost(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Cyprus",
            };
        }
    }
}