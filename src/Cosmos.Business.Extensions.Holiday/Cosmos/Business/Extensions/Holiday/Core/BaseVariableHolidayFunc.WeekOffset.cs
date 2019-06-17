using System;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class WeekOffsetVariableHolidayFunc : BaseVariableHolidayFunc
    {
        /// <summary>
        /// 月份
        /// </summary>
        public  abstract int Month { get; }

        /// <summary>
        /// 月份中的第几个礼拜
        /// </summary>
        protected abstract int WeekAtMonth { get; }

        /// <summary>
        /// 礼拜中的第几天<br />
        /// 顺序为：周日、一、二、三、四、五、六，值：1 ~ 7
        /// </summary>
        protected abstract DayOfWeek DayOfWeek { get; }

        protected int DayNumberOfWeek => DayOfWeek.ToInt();

        /// <summary>
        /// 节日长度，默认为 1 天
        /// </summary>
        protected virtual int Length { get; } = 1;

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var date = DateTimeFactory.OffsetByWeek(year, Month, WeekAtMonth, DayOfWeek);

            var builder = DailyAnswerBuilder.Create(Name).From(date);

            if (Length > 1)
                builder.To(Length);

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