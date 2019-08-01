using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Uruguay.Commemoration;
    using Definitions.SouthAmerica.Uruguay.Public;
    using Definitions.SouthAmerica.Uruguay.Religion;

    /// <summary>
    /// Uruguay holiday provider
    /// </summary>
    public class UruguayHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Uruguay;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = UyFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> UyFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ChildrensDay(), //1-6
            new LandingOfThe33PatriotsDay(), //4-19
            new InternationalWorkersDay(), //5-1
            new BattleOfLasPiedras(), //5-14
            new BirthdayOfJoséGervasioArtigasAndNeverAgainDay(), //6-19
            new ConstitutionDay(), //7-18
            new IndependenceDay(), //8-25
            new DayOfTheRace(), //10-12
            new DeceasedOnesDay(), //11-2
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = UyVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> UyVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new MaundyThursday(),
            new GoodFriday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Uruguay"
            };
        }
    }
}