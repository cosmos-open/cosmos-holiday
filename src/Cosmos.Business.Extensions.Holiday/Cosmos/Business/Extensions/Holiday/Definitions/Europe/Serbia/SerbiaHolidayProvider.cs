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
    using Definitions.Europe.Serbia.Commemoration;
    using Definitions.Europe.Serbia.Public;
    using Definitions.Europe.Serbia.Religion;

    /// <summary>
    /// Serbia holiday provider
    /// </summary>
    public class SerbiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SerbiaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Serbia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = RsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> RsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1 ~ 1-2
            new ChristmasDay(), //1-7
            new StatehoodDay(), //2-15 ~ 2-16
            new MayDay(), //5-1
            new ArmisticeDay(), //11-11
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = RsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> RsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterMonday(),
            new EasterSunday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Serbia"
            };
        }
    }
}