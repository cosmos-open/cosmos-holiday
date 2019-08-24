using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Argentina.Commemoration;
    using Definitions.SouthAmerica.Argentina.Public;
    using Definitions.SouthAmerica.Argentina.Religion;

    /// <summary>
    /// Argentina holiday provider
    /// </summary>
    public class ArgentinaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Argentina;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Argentina;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ArFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ArFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new TruthAndJustice(), //3-24
            new VeteransAndFallen(), //4-2
            new LabourDay(), //5-1
            new MayRevolution(), //5-25
            new Miguel(), //6-17
            new Belgrano(), //6-20
            new IndependenceDay(), //7-9
            new NationalSovereigntyDay(), //11-20
            new ImmaculateConceptionDay(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ArVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ArVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Argentina"
            };
        }
    }
}