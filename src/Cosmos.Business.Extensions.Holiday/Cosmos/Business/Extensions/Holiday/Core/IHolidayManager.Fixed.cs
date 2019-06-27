using System;
using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of Fixed Holiday Manager
    /// </summary>
    public interface IFixedHolidayManager
    {

        #region Add

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentNullException">The instance of <see cref="IFixedHolidayFunc"/> func should not be null.</exception>
        /// <exception cref="InvalidOperationException">Failed to add <see cref="IFixedHolidayFunc"/> func.</exception>
        void Add(IFixedHolidayFunc func);

        /// <summary>
        /// Add a collection of <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcColl"></param>
        void AddRange(IEnumerable<IFixedHolidayFunc> funcColl);

        #endregion

        #region Get func

        /// <summary>
        /// Get all fixed holiday func
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get();

        /// <summary>
        /// Get all fixed holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code);

        /// <summary>
        /// Get all fixed holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country);

        /// <summary>
        /// Get all fixed holiday func by special country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, string regionCode);

        /// <summary>
        /// Get all fixed holiday func by special country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, string regionCode);

        /// <summary>
        /// Get all fixed holiday func by special month
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(int month);

        /// <summary>
        /// Get all fixed holiday func by special month and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, int month);

        /// <summary>
        /// Get all fixed holiday func by special month and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, int month);

        /// <summary>
        /// Get all fixed holiday func by special month, country coed and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int month);

        /// <summary>
        /// Get all fixed holiday func by special month, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, string regionCode, int month);

        /// <summary>
        /// Get all fixed holiday func by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(int year, int month);

        /// <summary>
        /// Get all fixed holiday func by special year, month and country code..
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, int year, int month);

        /// <summary>
        /// Get all fixed holiday func by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, int year, int month);

        /// <summary>
        /// Get all fixed holiday func by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int year, int month);

        /// <summary>
        /// Get all fixed holiday func by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, string regionCode, int year, int month);

        /// <summary>
        /// Get all fixed holiday func by special year, month abd day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday func by special year, month, day, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday func by special year, month , day, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> Get(Country country, string regionCode, int year, int month, int day);

        #endregion

        #region Get DailyAnswer

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(int year);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month, int day);

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month, int day);

        #endregion
    }
}