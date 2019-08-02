using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Luxembourg.Commemoration;
    using Definitions.Europe.Luxembourg.Public;
    using Definitions.Europe.Luxembourg.Religion;
    using Definitions.Europe.Luxembourg.Tradition;

    /// <summary>
    /// Luxembourg holiday provider
    /// </summary>
    public class LuxembourgHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Luxembourg;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Luxembourg;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = LuFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> LuFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new EuropeDay(), //5-9
            new SovereignsBirthday(), //6-23
            new AssumptionDay(), //8-15
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = LuVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> LuVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new GoodFriday(),
            new AscensionDay(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Luxembourg"
            };
        }
    }
}