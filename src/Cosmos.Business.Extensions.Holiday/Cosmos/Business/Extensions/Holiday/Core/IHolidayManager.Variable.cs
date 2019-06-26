using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of Variable Holiday Manager
    /// </summary>
    public interface IVariableHolidayManager
    {

        #region Add

        /// <summary>
        /// Add <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func"></param>
        void Add(IVariableHolidayFunc func);

        /// <summary>
        /// Add a collection of <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcColl"></param>
        void AdRange(IEnumerable<IVariableHolidayFunc> funcColl);

        #endregion

        #region Get func

        /// <summary>
        /// Get all variable holiday func
        /// </summary>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get();

        /// <summary>
        /// Get all variable holiday func by special year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(int year);

        /// <summary>
        /// Get all variable holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(CountryCode code);

        /// <summary>
        /// Get all variable holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(Country country);

        /// <summary>
        /// Get all variable holiday func by special country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(CountryCode code, string regionCode);

        /// <summary>
        /// Get all variable holiday func by special country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(Country country, string regionCode);

        /// <summary>
        /// Get all variable holiday func by special year and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(CountryCode code, int year);

        /// <summary>
        /// Get all variable holiday func by special year and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(Country country, int year);

        /// <summary>
        /// Get all variable holiday func by special year, country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(CountryCode code, string regionCode, int year);

        /// <summary>
        /// Get all variable holiday func by special year, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> Get(Country country, string regionCode, int year);

        #endregion

        #region Get DailyAnswer

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(int year);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month, int day);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year and country code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special month, country code and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month and country code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, country code and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month, int day);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, day and country code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month, int day);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, day, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month, int day);

        /// <summary>
        /// Get all variable holiday <see cref="DailyAnswer"/> instance by special year, month, day, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month, int day);

        #endregion

    }
}