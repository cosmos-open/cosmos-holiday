using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Interface of holiday getter
    /// </summary>
    public interface IHolidayGetter
    {
        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month, int day);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month, int day);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month, int day);

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month, int day);
    }
}