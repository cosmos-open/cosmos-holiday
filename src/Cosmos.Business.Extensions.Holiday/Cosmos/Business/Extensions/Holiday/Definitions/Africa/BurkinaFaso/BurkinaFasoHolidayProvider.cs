using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.BurkinaFaso.Public;
    using Definitions.Africa.BurkinaFaso.Religion;
    using Definitions.Africa.BurkinaFaso.Tradition;

    /// <summary>
    /// BurkinaFaso holiday provider
    /// </summary>
    public class BurkinaFasoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BurkinaFasoRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.BurkinaFaso;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.BurkinaFaso;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BfFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BfFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new WomensDay(), //3-8
            new LabourDay(), //5-1
            new IndependenceDay(), //8-5
            new AssumptionDay(), //8-15
            new AllSaintsDay(), //11-1
            new ProclamationOfTheRepublic(), //12-11
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BfVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BfVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
            new AscensionDay(),
            new Pentecost(),
            new EndOfRamadan(), //1-shawwal
            new FeastOfTheSacrifice(), //10-Dhu al-Hijiah
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://fr.wikipedia.org/wiki/Burkina_Faso#F%C3%AAtes_et_jours_f%C3%A9ri%C3%A9s"
            };
        }
    }
}