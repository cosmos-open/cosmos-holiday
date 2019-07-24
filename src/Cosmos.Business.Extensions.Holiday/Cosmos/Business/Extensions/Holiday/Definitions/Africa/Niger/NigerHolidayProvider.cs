using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Niger.Public;
    using Definitions.Africa.Niger.Religion;

    /// <summary>
    /// Niger holiday provider
    /// </summary>
    public class NigerHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Niger;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Niger;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new IndependenceDay(), //3-21
            new ConcordDay(), //4-24
            new LabourDay(), //5-1
            new RepublicDay(),//12-18
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Niger"
            };
        }
    }
}