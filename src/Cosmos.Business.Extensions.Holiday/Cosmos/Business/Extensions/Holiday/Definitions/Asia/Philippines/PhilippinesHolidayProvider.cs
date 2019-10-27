using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Philippines.Commemoration;
    using Definitions.Asia.Philippines.Public;
    using Definitions.Asia.Philippines.Religion;

    /// <summary>
    /// Philippines holiday provider
    /// </summary>
    public class PhilippinesHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = PhilippinesRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Philippines;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Philippines;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PhFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PhFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new FirstPhilippineRepublicDay(),//1-23
            new ConstitutionDay(),//2-2
            new EDSARevolutionAnniversary(),//2-25
            new DayOfValor(),//4-9
            new LapuLapuDay(),//4-27
            new IndependenceDay(),//6-12
            new JoséRizalBirthday(),//6-19
            new LabourDay(), //5-1
            new IndependenceDay(), //8-17
            new AllSaintsDay(),//11-1
            new AllSoulsDay(),//11-2
            new BonifacioDay(),//11-30
            new Mary(),//12-8
            new ChristmasEve(),//12-24
            new ChristmasDay(), //12-25
            new RizalDay(),//12-30
            new NewYearsEve(),//12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PhVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PhVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new ChineseNewYear(),
            new LanternFestival(),
            new MaundyThursday(),//easter -3
            new GoodFriday(),//easter -2
            new HolySaturday(),//easter -1
            new EasterSunday(),//easter
            new EasterMonday(),//easter 1
            new IslamicNewYear(),
            new BirthdayOfMuhammad(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Philippines",
            };
        }
    }
}