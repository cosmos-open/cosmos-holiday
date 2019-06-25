using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Interface of holiday getter
    /// </summary>
    /// <typeparam name="THolidayProvider"></typeparam>
    public interface IHolidayGetter<THolidayProvider> where THolidayProvider : class, IHolidayProvider
    {
        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(int year, int month, int day);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year, int month, int day);
    }
}