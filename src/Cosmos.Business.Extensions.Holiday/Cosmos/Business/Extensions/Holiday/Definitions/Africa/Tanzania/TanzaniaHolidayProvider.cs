using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Tanzania.Commemoration;
    using Definitions.Africa.Tanzania.Public;
    using Definitions.Africa.Tanzania.Religion;

    /// <summary>
    /// Tanzania holiday provider
    /// </summary>
    public class TanzaniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Tanzania;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Tanzania;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = TzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> TzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ZanzibarRevolutionDay(), //1-2
            new KarumeDay(), //4-7
            new UnionDay(), //4-26
            new IndependenceDay(), //4-27
            new LabourDay(), //5-1
            new IndependenceDay(), //12-9
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = TzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> TzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new BirthdayOfMuhammad(),
            new EndOfRamadan(),
            new FeastOfTheSacrifice()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.rw/home/official_holidays/"
            };
        }
    }
}