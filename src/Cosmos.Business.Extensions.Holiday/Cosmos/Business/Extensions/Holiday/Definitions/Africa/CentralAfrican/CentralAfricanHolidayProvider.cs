using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.CentralAfrican.Public;
    using Definitions.Africa.CentralAfrican.Religion;
    using Definitions.Africa.CentralAfrican.Tradition;

    /// <summary>
    /// CentralAfrican holiday provider
    /// </summary>
    public class CentralAfricanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CentralAfricanRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CentralAfrican;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.CentralAfrican;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CfFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CfFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new BogandaDay(),//3-29
            new LabourDay(), //5-1
            new GeneralPrayerDay(),//6-30
            new IndependenceDay(), //8-13
            new AssumptionDay(), //8-15
            new AllSaintsDay(),//11-1
            new RepublicDay(),//12-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CfVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CfVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new AscensionDay(),
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
                "https://fr.wikipedia.org/wiki/R%C3%A9publique_centrafricaine#F.C3.AAtes_et_jours_f.C3.A9ri.C3.A9s",
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Central_African_Republic"
            };
        }
    }
}