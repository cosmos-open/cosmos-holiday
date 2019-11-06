using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Uganda.Commemoration;
    using Definitions.Africa.Uganda.Public;
    using Definitions.Africa.Uganda.Religion;

    /// <summary>
    /// Uganda holiday provider
    /// </summary>
    public class UgandaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Uganda;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Uganda;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = UgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> UgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LiberationDay(),//1-26
            new ArchbishopJananLuwumDay(),//2-16
            new WomensDay(),//3-8
            new IndependenceDay(), //4-27
            new LabourDay(), //5-1
            new MartyrsDay(),//6-3
            new NationalHeroesDay(),//6-9
            new IndependenceDay(), //10-9
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = UgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> UgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AshWednesday(),
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Uganda"
            };
        }
    }
}