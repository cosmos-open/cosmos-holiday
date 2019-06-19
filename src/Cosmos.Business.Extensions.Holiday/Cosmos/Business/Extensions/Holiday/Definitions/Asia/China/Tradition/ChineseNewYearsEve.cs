using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date.Chinese;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class ChineseNewYearsEve : BaseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Chinese New Year's Eve 
        /// </summary>
        public override string Name { get; } = "除夕";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_chuxi";

        public override DailyAnswer ToDailyAnswer(int year)
        {
            //算法一：根据元旦的农历时间算出其所在年份的十二月的最后一天（推荐）
            //算法二：根据指定年的农历大年初一向前倒退一天
            
            //推荐算法一的原因：
            //元旦通常在农历新年前，因此不存在修正 ChineseYear 的情况
            
            var date = ChineseDateInfo.Of(year, 1, 1);
            var chineseMonth = date.ChineseMonth;

            if (chineseMonth < 12)
            {
                //修正到农历十二月
                var offset = 12 - chineseMonth;
                date = date.AddMonths(offset);
            }

            var lastDay = date.GetDaysInMonth();
            var finalDate = ChineseDateInfo.OfLunar(date.ChineseYear, 12, lastDay);

            //农历十二月的最后一天，得到的是公历时间
            return DailyAnswerBuilder.Create(Name).From(finalDate.ToDateTime()).I18N(I18NIdentityCode).Build(finalDate.ChineseYear);
        }
    }
}