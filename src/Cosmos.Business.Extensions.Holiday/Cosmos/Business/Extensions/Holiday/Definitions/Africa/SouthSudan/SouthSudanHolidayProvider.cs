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
    using Definitions.Africa.SouthSudan.Commemoration;
    using Definitions.Africa.SouthSudan.Public;
    using Definitions.Africa.SouthSudan.Religion;

    /// <summary>
    /// SouthSudan holiday provider
    /// </summary>
    public class SouthSudanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SouthSudan;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.SouthSudan;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new PeaceAgreementDay(), //1-9
            new WomensDay(), //3-8
            new SplaDay(), //5-16
            new IndependenceDay(), //7-9
            new MartyrsDay(), //7-30
            new ChristmasDay(), //12-25
            new RepublicDay(), //12-28
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MothersDay(), //7-1st-monday
            new EndOfRamadan(),
            new FeastOfTheSacrifice()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_South_Sudan"
            };
        }
    }
}