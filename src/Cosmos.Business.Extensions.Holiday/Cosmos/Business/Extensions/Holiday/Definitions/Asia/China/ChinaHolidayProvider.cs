using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.China.Commemoration;
    using Definitions.Asia.China.Propaganda;
    using Definitions.Asia.China.Public;
    using Definitions.Asia.China.Religion;
    using Definitions.Asia.China.School;
    using Definitions.Asia.China.Tradition;

    /// <summary>
    /// China holiday provider
    /// </summary>
    public class ChinaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = ChinaRegions.GetEndolandRegionCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.China;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.China;

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

            regionCode = CountryHelper.FixRegionCode(Country.China, regionCode);

            switch (regionCode)
            {
                case "CN-HK":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.HK);
                case "CN-MO":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.MO);
                case "CN-TW":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.TW);
                default:
                    return base.DoesIncludeRegion(regionCode);
            }
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ValentinesDay(), //2-14
            new WomensDay(), //3-8
            new ArborDay(), //3-12
            new WorldConsumerRightsDay(), //3-15
            new AprilFoolsDay(), //4-1
            new MayDay(), //5-1
            new YouthDay(), //5-4
            new ChildrenDay(), //6-1
            new CPCFoundingDay(), //7-1
            new HongKongReturnDay(), //7-1
            new ArmyDay(), //8-1
            new ResistanceAgainstJapanDay(), //9-3
            new ChairmanMaosMemorialDay(), //9-9
            new TeachersDay(), //9-10
            new _0918(), //9-18
            new NationalDay(), //10-1
            new MacaosReturnDay(), //12-20
            new Christmas(), //12-25
            new ChairmanMaosBirthday(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new ChineseNewYearsEve(), //农历（上一年）12-30
            new ChineseNewYear(), //农历1-1
            new LanternFestival(), //农历1-15
            new TombSweepingDay(), //春分后的第15天
            new DragonBoatFestival(), //农历5-5
            new MothersDay(), //母亲节，5月第二个周日
            new ZhuCan(), //全国助残日，5月第三个周日
            new FathersDay(), //父亲节，6月第三个周日
            new DoubleSeventhFestival(), //农历7-7
            new ZhongYuanDay(), //农历7-15
            new MidAutumnFestival(), //农历8-15
            new DoubleNinthFestival(), //农历9-9
            new LabaFestival(), //农历12-8
            new XiaoNianNorth(), //农历12-23
            new XiaoNianSouth(), //农历12-24
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_China",
            };
        }
    }
}