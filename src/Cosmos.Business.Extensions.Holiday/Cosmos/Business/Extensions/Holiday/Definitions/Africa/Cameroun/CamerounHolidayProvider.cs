using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Cameroun.Public;
    using Definitions.Africa.Cameroun.Religion;

    /// <summary>
    /// Cameroun holiday provider
    /// </summary>
    public class CamerounHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CamerounRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Cameroun;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Cameroun;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CmFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new YouthDay(),//2-11
            new LabourDay(), //5-1
            new NationalDay(), //5-20
            new AssumptionDay(), //8-15
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new AscensionDay(),
            new EndOfRamadan(),
            new FeastOfTheSacrifice(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://fr.wikipedia.org/wiki/Cameroun"
            };
        }
    }
}