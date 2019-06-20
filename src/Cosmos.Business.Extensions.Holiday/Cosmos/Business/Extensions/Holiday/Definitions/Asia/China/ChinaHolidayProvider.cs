using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China
{
    using Commemoration;
    using Propaganda;
    using Public;
    using Religion;
    using School;
    using Tradition;

    public class ChinaHolidayProvider : BaseDefinitionRegister
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;
        
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
            new NineOneEightDay(), //9-18
            new NationalDay(), //10-1
            new MacaosReturnDay(), //12-20
            new Christmas(), //12-25
            new ChairmanMaosBirthday(), //12-26
        };

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

        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_China",
            };
        }
    }
}