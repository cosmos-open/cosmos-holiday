using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Venezuela.Commemoration;
    using Definitions.SouthAmerica.Venezuela.Public;
    using Definitions.SouthAmerica.Venezuela.Religion;
    using Definitions.SouthAmerica.Venezuela.School;
    using Definitions.SouthAmerica.Venezuela.Propaganda;
    using Definitions.SouthAmerica.Venezuela.Tradition;

    /// <summary>
    /// Venezuela holiday provider
    /// </summary>
    public class VenezuelaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Venezuela;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = VeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> VeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new FeastOfTheDivinaPastora(), //1-14
            new TeachersDay(), //1-15
            new YouthDay(), //2-12
            new FederationDay(), //2-20
            new InternationalWomensDay(), //3-8
            new StJosephsDay(), //3-19
            new SlaveryAbolitionAnniversary(), //3-21
            new FoundationAnniversaryDay(), //3-31
            new IndependenceMovement(), //4-19
            new LabourDay(), //5-1
            new FiestaDeLasCruces(), //5-3
            new ArmyDay(), //6-24
            new JournalistsDay(), //6-27
            new IndependenceDay(), //7-6
            new NavyDay(), //7-24
            new CaracasCityFoundationDay(), //7-25
            new FlagDay(), //8-3
            new BirthOfTheBlessedVirginMary(), //9-8
            new FeastOfTheOurLadyOfMercy(), //9-24
            new IndigenousResistance(), //10-12
            new AllSaintsDay(), //11-1
            new AllSoulsDay(), //11-2
            new FeriaOfLaChinita(), //11-17 ~ 11-19
            new UniversityStudentsDay(), //11-21
            new ImmaculateConception(), //12-8
            new LoyaltyDay(), //12-8
            new SimonBolivarMemorialDay(), //12-17
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = VeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> VeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new MothersDay(), //5-2nd-sunday
            new FathersDay(), //6-3rd-sunday
            new ChildrensDay(), //7-3rd-sunday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Venezuela"
            };
        }
    }
}