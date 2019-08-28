using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Chile.Commemoration;
    using Definitions.SouthAmerica.Chile.Public;
    using Definitions.SouthAmerica.Chile.Religion;
    using Definitions.SouthAmerica.Chile.Tradition;

    /// <summary>
    /// Chile holiday provider
    /// </summary>
    public class ChileHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = ChileRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Chile;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Chile;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ClFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ClFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new LabourDay(), //5-1
            new NavyDay(), //5-21
            new BattleOfArica(), //6-7
            new SaintPeterAndSaintPaul(), //6-26
            new OurLadyOfMountCarmel(), //7-16
            new SaintLawrence(), //8-10
            new NationalMinersDay(), //8-10
            new AssumptionOfMary(), //8-15
            new NationalHoliday0918(), //9-18
            new ArmyDay(), //9-19
            new FiestaDeLaPampilla(), //9-20
            new StraitOfMagellan(), //9-21
            new LosRíosRegionAnniversary(), //10-2
            new ColumbusDay(), //10-9
            new ReformationDay(), //10-27
            new AllSaintsDay(), //11-1
            new Presidential(), //11-19
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ClVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ClVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new GoodFriday(),
            new HolySaturday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Chile",
                "https://pt.wikipedia.org/wiki/Feriados_no_Brasil"
            };
        }
    }
}