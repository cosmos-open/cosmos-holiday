using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Bahamas.Public;
    using Definitions.NorthAmerica.Bahamas.Religion;
    using Definitions.NorthAmerica.Bahamas.Commemoration;

    /// <summary>
    /// Bahamas Holiday Provider
    /// </summary>
    public class BahamasHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BahamasRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bahamas;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MajorityRuleDay(), //1-10
            new PerryChristieDay(), //4-1
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new EasterSunday(),
            new GoodFriday(),
            new WhitSunday(),
            new WhitMonday(),
            new MothersDay(),//5-2nd-sunday
            new LabourDay(),//6-1st-friday
            new IndependenceDay(), //7-10
            new EmancipationDay(), //8-1st-monday
            new NationalHeroesDay(), //10-12
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_Bahamas"
            };
        }
    }
}