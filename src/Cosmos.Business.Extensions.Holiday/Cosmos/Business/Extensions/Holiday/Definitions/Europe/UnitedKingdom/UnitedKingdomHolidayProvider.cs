using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.UnitedKingdom.Commemoration;
    using Definitions.Europe.UnitedKingdom.Public;
    using Definitions.Europe.UnitedKingdom.Bank;
    using Definitions.Europe.UnitedKingdom.Religion;

    /// <summary>
    /// United Kingdom holiday provider
    /// </summary>
    public class UnitedKingdomHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
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
        /// Does this provider include special type of regions?
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public override bool DoesIncludeRegion(string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;

            regionCode = CountryHelper.FixRegionCode(Country.UnitedKingdom, regionCode);

            switch (regionCode)
            {
                case "GB-GG":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.GG);
                case "GB-JE":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.JE);
                case "GB-IM":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.IM);
                case "GB-GI":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.GI);
                case "GB-BM":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.BM);
                case "GB-KY":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.KY);
                case "GB-TC":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.TC);
                case "GB-VG":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.VG);
                case "GB-AI":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.AI);
                case "GB-MS":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.MS);
                case "GB-SH":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.SH);
                case "GB-GS":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.GS);
                case "GB-IO":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.IO);
                case "GB-PN":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.PN);
                default:
                    return base.DoesIncludeRegion(regionCode);
            }
        }

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
            new StStephensDay(), //12-16
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