using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Ethiopia.Public;
    using Definitions.Africa.Ethiopia.Religion;

    /// <summary>
    /// Ethiopia holiday provider
    /// </summary>
    public class EthiopiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = EthiopiaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Ethiopia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Ethiopia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = EtFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> EtFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new Epiphany(), //1-19
            new VictoryAtAdwaDay(),//3-2
            new DayOfLament(),//3-28
            new DergDownfallDay(),//5-28
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = EtVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> EtVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new FindingOfTHeTrueCross(),//9-27
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Ethiopia",
            };
        }
    }
}