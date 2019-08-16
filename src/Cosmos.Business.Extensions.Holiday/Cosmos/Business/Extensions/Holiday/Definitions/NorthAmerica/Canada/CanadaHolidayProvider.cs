using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Canada.Commemoration;
    using Definitions.NorthAmerica.Canada.Public;
    using Definitions.NorthAmerica.Canada.Religion;

    /// <summary>
    /// Canada Holiday Provider
    /// </summary>
    public class CanadaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CanadaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Canada;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new ArmisticeDay(), //11-11
            new StStephensDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new FamilyDay(), //2-1
            new FamilyDayBc(), //2-1
            new FamilyDayNb(), //2-1
            new StPatricksDay(), //3-17
            new StGeorgesDay(), //4-23
            new VictoriaDay(), //5-24
            new AboriginalDay(), //6-21
            new NationalHoliday(), //6-24
            new CanadaDay(), //7-1
            new OrangemensDay(), //7-12
            new CivicHoliday(), //8月第一个周一
            new DiscoveryDay(), //8月第三个周一
            new GoldCupParadeDay(), //8月第三个周五
            new LabourDay(), //9-1
            new Thanksgiving(), //10月第二个周一
            new RemembranceDay(), //11-11
            new Christmas(), //12-25
            new BoxingDay(), //12-26
            new BoxingDayAll(), //12-26
            new EasterMonday(),
            new EasterMondayAbPe(),
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Canada",
            };
        }
    }
}