using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Madagascar.Commemoration;
    using Definitions.Africa.Madagascar.Public;
    using Definitions.Africa.Madagascar.Religion;

    /// <summary>
    /// Madagascar holiday provider
    /// </summary>
    public class MadagascarHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Madagascar;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Madagascar;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MartyrsDay(), //3-29
            new LabourDay(), //5-1
            new IndependenceDay(), //6-26
            new AssumptionDay(), //8-15
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AscensionDay(),
            new EasterMonday(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Madagascar"
            };
        }
    }
}