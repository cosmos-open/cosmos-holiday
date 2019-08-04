using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Macedonia.Commemoration;
    using Definitions.Europe.Macedonia.Public;
    using Definitions.Europe.Macedonia.Religion;

    /// <summary>
    /// Macedonia holiday provider
    /// </summary>
    public class MacedoniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Macedonia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Macedonia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MkFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MkFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ChristmasDay(), //1-7
            new LabourDay(), //5-1
            new SaintsCyrilAndMethodiuDay(), //5-24
            new DayOfTheRepublic(), //8-2
            new IndependenceDay(), //9-8
            new RevolutionDay(), //10-11
            new RevolutionaryStruggle(), //10-23
            new SaintClementOfOhridDay(), //12-8
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MkVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MkVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Macedonia"
            };
        }
    }
}