using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Nicaragua.Commemoration;
    using Definitions.SouthAmerica.Nicaragua.Public;
    using Definitions.SouthAmerica.Nicaragua.Religion;

    /// <summary>
    /// Nicaragua holiday provider
    /// </summary>
    public class NicaraguaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Nicaragua;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Nicaragua;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new AirForceDay(), //2-1
            new LabourDay(), //5-1
            new ArmyDay(), //5-27
            new LiberationDay(), //7-19
            new BattleOfSanJacinto(), //9-14
            new IndependenceDay(), //9-15
            new IndigenousResistanceDay(), //10-12
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new HolyThursday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Nicaragua"
            };
        }
    }
}