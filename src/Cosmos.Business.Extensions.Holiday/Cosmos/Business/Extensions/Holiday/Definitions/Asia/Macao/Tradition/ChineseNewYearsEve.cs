using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date.Chinese;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Tradition
{
    /// <summary>
    /// 除夕 Chinese New Year's Eve 
    /// </summary>
    public class ChineseNewYearsEve : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macao;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "除夕";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_chuxi";

        /// <inheritdoc />
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
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(finalDate.ToDateTime())
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(finalDate.ChineseYear);
        }
    }
}