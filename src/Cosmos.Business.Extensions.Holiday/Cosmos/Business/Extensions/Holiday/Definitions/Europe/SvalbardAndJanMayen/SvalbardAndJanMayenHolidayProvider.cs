using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.SvalbardAndJanMayen.Commemoration;
    using Definitions.Europe.SvalbardAndJanMayen.Public;
    using Definitions.Europe.SvalbardAndJanMayen.Religion;

    /// <summary>
    /// SvalbardAndJanMayen holiday provider
    /// </summary>
    public class SvalbardAndJanMayenHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SvalbardAndJanMayen;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Norway;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NoSjFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NoSjFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new ConstitutionDay(), //5-17
            new ChristmasDay(), //12-25
            new ChristmasDaySecond(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NoSjVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NoSjVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new EasterSunday(),
            new GoodFriday(),
            new AscensionDay(),
            new WhitSunday(),
            new WhitMonday(),
            new MaundyThursday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Svalbard"
            };
        }
    }
}