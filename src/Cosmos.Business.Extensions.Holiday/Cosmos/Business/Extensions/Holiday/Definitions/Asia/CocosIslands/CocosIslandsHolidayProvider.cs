using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.CocosIslands.Commemoration;
    using Definitions.Asia.CocosIslands.Public;
    using Definitions.Asia.CocosIslands.Religion;

    /// <summary>
    /// CocosIslands holiday provider
    /// </summary>
    public class CocosIslandsHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CocosIslands;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CcFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CcFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(),//3-20
            new SelfDeterminationDay(),//4-6
            new AnzacDay(),//4-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CcVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CcVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AustraliaDay(),//1-26
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
            new EidAlFitrEndOfRamadan(), //1-shawwal
            new DayOfTheSacrifice(), // 10 Dhu al-Hijjah
            new IslamicNewYear(), //1 Muharram
            new BirthdayOfMuhammad(), //12 Rabi al-awwal
            new ChineseNewYear(),
            new EasterMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://regional.gov.au/territories/indian_ocean/iot_gazette/index.aspx",
                "http://regional.gov.au/territories/indian_ocean/iot_bulletins/2017/A31-2017-Cocos-Keeling-Island-Public-Holidays-2018.aspx"
            };
        }
    }
}