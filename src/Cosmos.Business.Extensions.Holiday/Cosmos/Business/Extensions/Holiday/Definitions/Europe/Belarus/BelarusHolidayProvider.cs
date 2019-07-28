using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Belarus.Commemoration;
    using Definitions.Europe.Belarus.Public;
    using Definitions.Europe.Belarus.Religion;

    /// <summary>
    /// Belarus holiday provider
    /// </summary>
    public class BelarusHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BelarusRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Belarus;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Belarus;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ByFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ByFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new OrthodoxChristmasDay(), //1-7
            new InternationalWomensDay(), //3-8
            new LabourDay(), //5-1
            new VictoryDay(), //5-9
            new IndependenceDay(), //7-3
            new OctoberRevolutionDay(), //11-7
            new CatholicChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ByVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ByVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CommemorationDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Belarus"
            };
        }
    }
}