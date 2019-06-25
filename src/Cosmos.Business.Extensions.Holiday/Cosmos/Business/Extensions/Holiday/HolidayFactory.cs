using System;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Holiday factory
    /// </summary>
    public static class HolidayFactory
    {
        /// <summary>
        /// Create a new instance for <see cref="IHolidayInfo"/>
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IHolidayInfo Create(DailyAnswer answer)
        {
            if (answer == null)
                throw new ArgumentNullException(nameof(answer));
            return answer.Length == 1
                ? new HolidayInfo(answer)
                : new PeriodHolidayInfo(answer) as IHolidayInfo;
        }
    }
}