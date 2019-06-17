using Cosmos.Business.Extensions.Holiday.Core.Helpers;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class ChineseVariableHolidayFunc : BaseVariableHolidayFunc
    {
        /// <summary>
        /// 农历月份
        /// </summary>
        protected abstract int ChineseMonth { get; }

        /// <summary>
        /// 农历日份
        /// </summary>
        protected abstract int ChineseDay { get; }

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calendar = ChineseLunisolarCalendarHelper.Instance;
            var leapMonth = calendar.GetLeapMonthAndCache(year);
            var date = calendar.ToDateTime(year, ChineseLunisolarCalendarHelper.MoveMonth(ChineseMonth, leapMonth), ChineseDay);

            return DailyAnswerBuilder.Create(Name).From(date).Build(year);
        }
    }
}