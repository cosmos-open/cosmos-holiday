using Cosmos.Business.Extensions.Holiday.Core.Helpers;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// 运行时动态生成的 FixedHolidayFunc，用于基于配置生成固定节日
    /// </summary>
    public class RuntimeFixedHolidayFunc : IFixedHolidayFunc
    {
        public string Name { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public (int Month, int Day)? FromDate { get; set; }

        public (int Month, int Day)? ToDate { get; set; }

        public bool MatchDate(int month)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, ToDate.Value.Month, month);

            return Month == month;
        }

        public bool MatchDate(int month, int day)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, FromDate.Value.Day, ToDate.Value.Month, ToDate.Value.Day, month, day);

            return Month == month && Day == day;
        }

        public string I18NIdentityCode { get; set; }

        public int? Since { get; set; }

        public int? End { get; set; }

        public int? TimeStepValue { get; set; }

        public DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name).From(year, Month, Day);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            return builder.Build(year);
        }
    }
}