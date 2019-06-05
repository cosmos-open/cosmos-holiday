using System;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public class DailyAnswer
    {
        public string Name { get; set; }

        public string I18NIdentityCode { get; set; }

        public DateInfo FromDate { get; set; }

        public DateInfo ToDate { get; set; }

        public int Length => (ToDate.ToDateTime() - FromDate.ToDateTime()).Days + 1;

        internal DailyTimesAnswer _times;

        public int? Times => _times?.GetTimes(FromDate.Year);

        /// <summary>
        /// 用于计算是第几届的节日
        /// </summary>
        public class DailyTimesAnswer
        {
            public int? SinceYear { get; set; }
            public int? EndYear { get; set; }
            public int? StepValue { get; set; }

            public int? GetTimes(int year)
            {
                if (!SinceYear.HasValue || !StepValue.HasValue)
                    return null;

                if (SinceYear.Value > year)
                    return null;

                if (EndYear.HasValue && EndYear.Value < year)
                    return null;

                if (StepValue.Value <= 0)
                    return null;

                return (int) Math.Floor((double) (year - SinceYear.Value + 1) / StepValue.Value);
            }
        }
    }
}