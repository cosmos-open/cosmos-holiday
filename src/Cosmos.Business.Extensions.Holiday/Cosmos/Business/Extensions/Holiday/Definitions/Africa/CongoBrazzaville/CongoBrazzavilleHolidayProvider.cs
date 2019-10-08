using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.CongoBrazzaville.Public;
    using Definitions.Africa.CongoBrazzaville.Religion;
    using Definitions.Africa.CongoBrazzaville.Tradition;

    /// <summary>
    /// CongoBrazzaville holiday provider
    /// </summary>
    public class CongoBrazzavilleHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CongoBrazzavilleRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CongoBrazzaville;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.CongoBrazzaville;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new Holiday0610(), //6-10
            new AssumptionDay(), //8-15
            new AllSaintsDay(), //11-1
            new NationalDay(), //11-28
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new AscensionDay(),
            new WhitSunday(),
            new WhitMonday()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://fr.wikipedia.org/wiki/R%C3%A9publique_du_Congo"
            };
        }
    }
}