using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Lesotho.Commemoration;
    using Definitions.Africa.Lesotho.Public;
    using Definitions.Africa.Lesotho.Religion;

    /// <summary>
    /// Lesotho holiday provider
    /// </summary>
    public class LesothoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = LesothoRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Lesotho;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Lesotho;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = LsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> LsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MoshoeshoeDay(), //3-11
            new WorkersDay(), //5-1
            new AscensionDay(), //5-9
            new AfricaDay(), //5-25
            new HeroesDay(), //5-25
            new KingLetsieIIIsBirthday(), //7-17
            new IndependenceDay(), //10-4
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = LsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> LsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Lesotho"
            };
        }
    }
}