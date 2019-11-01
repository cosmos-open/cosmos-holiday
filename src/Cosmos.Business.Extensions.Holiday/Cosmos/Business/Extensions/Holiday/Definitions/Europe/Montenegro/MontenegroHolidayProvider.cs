using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Montenegro.Commemoration;
    using Definitions.Europe.Montenegro.Public;
    using Definitions.Europe.Montenegro.Religion;
    using Definitions.Europe.Montenegro.Tradition;

    /// <summary>
    /// Montenegro holiday provider
    /// </summary>
    public class MontenegroHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Montenegro;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new MayDay(),
            new AssumptionDay(), //8-15
            new ChristmasEve(),//12-24
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new IndependenceDay21(),//5-21
            new IndependenceDay22(),//5-22
            new StatehoodDay(),//7-13
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new BirthdayOfMuhammad(),
            new IslamicNewYear(),
            new NewYearsDay(), //1-1
            new AllSaintsDay(), //11-1
            new EndOfRamadan(), 
            new FeastOfTheSacrifice(),
            new MuhammadsAscensionToHeaven(),
            new BaraAtNight(),
            new FirstDayOfRamadan(),
            new NightOfPower(),
            
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Montenegro"
            };
        }
    }
}