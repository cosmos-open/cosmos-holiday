using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Chinese variable holiday func
    /// </summary>
    public abstract class ChineseVariableHolidayFunc : BaseVariableHolidayFunc
    {

        #region Chinese Date

        /// <summary>
        /// 农历月份
        /// </summary>
        protected abstract int ChineseMonth { get; }

        /// <summary>
        /// 农历日份
        /// </summary>
        protected abstract int ChineseDay { get; }

        #endregion

        #region To daily answer

        /// <summary>
        /// Convert to <see cref="DailyAnswer"/>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calendar = ChineseLunisolarCalendarHelper.Instance;
            var leapMonth = calendar.GetLeapMonthAndCache(year);
            var date = calendar.ToDateTime(year, ChineseLunisolarCalendarHelper.MoveMonth(ChineseMonth, leapMonth), ChineseDay);

            return DailyAnswerBuilder
                .Create(Name)
                .From(date)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }

        #endregion

    }
}