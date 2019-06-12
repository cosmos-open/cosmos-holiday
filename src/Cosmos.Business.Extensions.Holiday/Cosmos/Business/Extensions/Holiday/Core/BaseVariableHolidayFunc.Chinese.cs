using Cosmos.Business.Extensions.Holiday.Core.Helpers;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class ChineseVariableHolidayFunc : BaseVariableHolidayFunc
    {
        protected abstract int Month { get; }

        protected abstract int Day { get; }

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calendar = ChineseLunisolarCalendarHelper.Instance;
            var leapMonth = calendar.GetLeapMonthAndCache(year);
            var date = calendar.ToDateTime(year, ChineseLunisolarCalendarHelper.MoveMonth(Month, leapMonth), Day);

            return DailyAnswerBuilder.Create(Name).From(date).Build(year);
        }
    }
}