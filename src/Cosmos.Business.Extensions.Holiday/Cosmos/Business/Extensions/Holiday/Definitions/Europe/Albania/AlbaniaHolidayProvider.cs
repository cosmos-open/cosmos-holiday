using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Albania.Commemoration;
    using Definitions.Europe.Albania.Public;
    using Definitions.Europe.Albania.Religion;
    using Definitions.Europe.Albania.School;
    using Definitions.Europe.Albania.Tradition;

    /// <summary>
    /// Albania holiday provider
    /// </summary>
    public class AlbaniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Albania;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => AlbaniaRegions.GetAllRegonCodes();

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AlFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AlFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LeagueOfLezhëday(), //3-2
            new TeachersDay(), //3-7
            new MothersDay(), //3-8
            new SummerDay(), //3-14
            new Nowruz(), //3-22
            new MayDay(), //5-1
            new ChildrensDay(), //6-1
            new MotherTeresaDay(), //10-19
            new AlphabetDay(), //11-22
            new IndependenceDay(), //11-28
            new LiberationDay(), //11-29
            new YouthDay(), //12-8
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AlVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AlVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
            new EndOfRamadan(), //1 shawwal
            new FeastOfTheSacrifice(), //10-Dhu al-Hijjah
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Albania"
            };
        }
    }
}