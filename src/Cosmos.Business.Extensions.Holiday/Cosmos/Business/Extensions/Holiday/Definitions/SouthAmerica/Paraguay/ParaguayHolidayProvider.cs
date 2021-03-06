using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Paraguay.Commemoration;
    using Definitions.SouthAmerica.Paraguay.Public;
    using Definitions.SouthAmerica.Paraguay.Religion;

    /// <summary>
    /// Paraguay holiday provider
    /// </summary>
    public class ParaguayHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Paraguay;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Paraguay;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PyFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PyFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Heroesday(), //3-1
            new LabourDay(), //5-1
            new IndependenceDay(), //5-14 ~ 5-15
            new ChacoArmistice(), //6-12
            new FoundingOfAsunción(), //8-15
            new BoqueronBattleVictoryDay(), //9-29
            new VirginOfCaacupe(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PyVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PyVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Paraguay"
            };
        }
    }
}