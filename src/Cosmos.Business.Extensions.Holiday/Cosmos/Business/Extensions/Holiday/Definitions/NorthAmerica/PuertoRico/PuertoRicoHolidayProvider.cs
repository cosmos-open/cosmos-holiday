using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.PuertoRico.Public;
    using Definitions.NorthAmerica.PuertoRico.Religion;
    using Definitions.NorthAmerica.PuertoRico.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class PuertoRicoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.PuertoRico;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = UsPrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> UsPrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new ThreeKingsDay(), //1-6
            new Epiphany(), //1-6
            new BirthdayOfLuisMuñozMarín(), //2-18
            new EmancipationDay(), //3-22
            new PuertoRicoConstitutionDay(), //7-25
            new BirthdayOfDrJoséCelsoBarbosa(), //7-27
            new DiscoveryOfPuertoRico(), //11-19
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = UsPrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> UsPrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new BirthdayOfEugenioMaríaDeHostos(), //1-2nd-monday
            new MartinLutherKingJrDay(), //1-3rd-monday
            new PresidentsDay(), //2-3rd-monday
            new BirthdayOfJoséDeDiego(), //4-3rd-monday
            new IndependenceDay(), //7-4
            new BirthdayOfDonLuisMuñozRivera(), //7-3rd-monday
            new LabourDay(), //9-1st-monday
            new ColumbusDay(), //10-2nd-monday
            new VeteransDay(), //11-11
            new ThanksgivingDay(), //11-4th-thursday
            new GoodFriday(),
            new MemorialDay(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Puerto_Rico",
                "https://www.timeanddate.com/holidays/puerto-rico/2017#!hol=9",
                "http://www.puertorico.com/official-holidays/",
                "http://www.topuertorico.org/reference/holi.shtml"
            };
        }
    }
}