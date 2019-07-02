using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.UnitedKingdom.Commemoration;
    using Definitions.Europe.UnitedKingdom.Public;
    using Definitions.Europe.UnitedKingdom.Bank;

    /// <summary>
    /// United Kingdom holiday provider
    /// </summary>
    public class UnitedKingdomHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = UnitedKingdomRegions.GetMainRegionCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GbFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GbFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new SaintPatrickDay(), //3-17
            new BattleOfTheBoyne(), //7-12
            new SaintAndrewDay(), //11-30
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GbVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GbVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NewYearsDayNir(), //1-1
            new NewYearsDaySct(), //1-1，一年第一个周四
            new NewYearsDayEngWls(), //1-1，一年第一个周一
            new NewYear2Day(), //1-2
            new EarlyMayBank(), //5月第二个周一
            new SpringBankHoliday(), //5月最后一个周一
            new SummerBankHolidaySct(), //8月第一个周一
            new SummerBankHoliday(), //8月最后一个周一
            new ChristmasDay(), //12-25
            new StStephenDay(), //12-16
            new EasterMonday(),
            new GoodFriday()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_United_Kingdom",
                "https://de.wikipedia.org/wiki/Feiertage_im_Vereinigten_K%C3%B6nigreich"
            };
        }
    }
}