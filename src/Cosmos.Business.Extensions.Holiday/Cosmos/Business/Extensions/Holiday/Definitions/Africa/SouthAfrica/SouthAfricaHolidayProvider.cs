using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.SouthAfrica.Public;
    using Definitions.Africa.SouthAfrica.Religion;
    using Definitions.Africa.SouthAfrica.Tradition;

    /// <summary>
    /// SouthAfrica holiday provider
    /// </summary>
    public class SouthAfricaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SouthAfrica;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.SouthAfrica;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ZaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ZaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new HumanRightsDay(), //3-21
            new FreedomDay(), //4-27
            new WorkersDay(), //5-1
            new YouthDay(), //6-16
            new NationalWomensDay(), //8-9
            new HeritageDay(), //9-24
            new DayOfReconciliation(), //12-16
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ZaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ZaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new FamilyDay(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_South_Africa"
            };
        }
    }
}