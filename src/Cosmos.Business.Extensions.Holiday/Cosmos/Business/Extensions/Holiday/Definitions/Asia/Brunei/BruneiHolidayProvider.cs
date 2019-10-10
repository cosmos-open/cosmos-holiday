using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Brunei.Commemoration;
    using Definitions.Asia.Brunei.Public;
    using Definitions.Asia.Brunei.Religion;

    /// <summary>
    /// Brunei holiday provider
    /// </summary>
    public class BruneiHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BruneiRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Brunei;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BnFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BnFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NationalDay(), //2-23
            new ArmyForcesDay(), //3-31
            new SultansBirthday(), //7-15
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BnVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BnVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new FirstDayOfRamadan(), //1 Ramadan
            new NuzulAlQuran(), //17 Ramadan
            new EidAlFitrEndOfRamadan(), //1-shawwal
            new DayOfTheSacrifice(), // 10 Dhu al-Hijjah
            new IslamicNewYear(), //1 Muharram
            new BirthdayOfMuhammad(), //12 Rabi al-awwal
            new MuhammadsAscensionToHeaven(), //27-rajab
            new ChineseNewYear(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Brunei"
            };
        }
    }
}