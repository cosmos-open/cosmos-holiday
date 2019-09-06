using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Angola.Commemoration;
    using Definitions.Africa.Angola.Public;
    using Definitions.Africa.Angola.Religion;

    /// <summary>
    /// Angola holiday provider
    /// </summary>
    public class AngolaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = AngolaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Angola;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Angola;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LiberationDay(), //2-4
            new WomensDay(), //3-8
            new PeaceDay(), //4-4
            new LabourDay(), //5-1
            new NationalHeroDay(), //9-17
            new AllSoulsDay(), //11-2
            new IndependenceDay(), //11-11
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterSunday(),
            new MothersDay(), //5-1st-sunday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://pt.wikipedia.org/wiki/Feriados_em_Angola"
            };
        }
    }
}