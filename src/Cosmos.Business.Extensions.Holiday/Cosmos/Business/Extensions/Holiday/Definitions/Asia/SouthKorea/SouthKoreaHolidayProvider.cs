using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.SouthKorea.Public;
    using Definitions.Asia.SouthKorea.Religion;

    /// <summary>
    /// SouthKorea holiday provider
    /// </summary>
    public class SouthKoreaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SouthKoreaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SouthKorea;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.SouthKorea;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = KrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> KrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new IndependenceMovementDay(),//3-1
            new ChildrensDay(), //5-5
            new MemorialDay(),//6-6
            new ConstitutionDay(),//7-17
            new LiberationDay(),//8-15
            new NationalFoundationDay(),//10-3
            new HangulDay(), //10-9
            new Christmas(),//12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = KrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> KrVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_SouthKorea"
            };
        }
    }
}