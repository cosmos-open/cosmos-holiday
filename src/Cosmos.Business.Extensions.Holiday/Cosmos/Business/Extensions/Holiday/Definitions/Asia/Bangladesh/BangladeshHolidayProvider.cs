using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Bangladesh.Commemoration;
    using Definitions.Asia.Bangladesh.Public;

    /// <summary>
    /// Bangladesh holiday provider
    /// </summary>
    public class BangladeshHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BangladeshRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bangladesh;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BdFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BdFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new GenocideRemembranceDay(), //3-25
            new ArmyForcesDay(), //11-21
            new MartyrsDay(), //12-14
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BdVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BdVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new BuddhasBirthday(), //5-19
            new KrishnaJanmashtami(), //8-24
            new DurgaPuja(), //10-8
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bangladesh",
                "https://en.wikipedia.org/wiki/Bengali_calendars"
            };
        }
    }
}