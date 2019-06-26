using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of Holiday Manager
    /// </summary>
    // ReSharper disable once PossibleInterfaceMemberAmbiguity
    public interface IHolidayManager : IFixedHolidayManager, IVariableHolidayManager, IWeekendHolidayManager
    {

        #region Holiday

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(int year);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(int year, int month);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(int year, int month, int day);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month, int day);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, int year);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month, int day);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month, int day);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month);

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month, int day);

        #endregion

    }
}