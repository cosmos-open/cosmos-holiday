using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core.Trees;
using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday Manager
    /// </summary>
    public partial class HolidayManager : IHolidayManager
    {
        private readonly DailyNodeTree _fixedDailyNodeTree;
        private readonly VariableDailyCache _variableDailyNodeTree;

        /// <summary>
        /// Create a new instance of <see cref="HolidayManager"/>
        /// </summary>
        /// <param name="dailyNodeTree"></param>
        /// <param name="variableDailyNodeTree"></param>
        public HolidayManager(DailyNodeTree dailyNodeTree, VariableDailyNodeTree variableDailyNodeTree)
        {
            _fixedDailyNodeTree = dailyNodeTree ?? throw new ArgumentNullException(nameof(dailyNodeTree));
            _variableDailyNodeTree = new VariableDailyCache(variableDailyNodeTree ?? throw new ArgumentNullException(nameof(variableDailyNodeTree)));
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(int year)
        {
            foreach (var answer in GetFixedHolidays(year))
                yield return answer;
            foreach (var answer in GetVariableHolidays(year))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(int year, int month)
        {
            foreach (var answer in GetFixedHolidays(year, month))
                yield return answer;
            foreach (var answer in GetVariableHolidays(year, month))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(year, month, day))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year)
        {
            foreach (var answer in GetFixedHolidays(code, year))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, year))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month)
        {
            foreach (var answer in GetFixedHolidays(code, year, month))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, year, month))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(code, year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, year, month, day))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, int year)
        {
            foreach (var answer in GetFixedHolidays(country, year))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, year))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month)
        {
            foreach (var answer in GetFixedHolidays(country, year, month))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, year, month))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(country, year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, year, month, day))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year)
        {
            foreach (var answer in GetFixedHolidays(code, regionCode, year))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, regionCode, year))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month)
        {
            foreach (var answer in GetFixedHolidays(code, regionCode, year, month))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, regionCode, year, month))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(code, regionCode, year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(code, regionCode, year, month, day))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year)
        {
            foreach (var answer in GetFixedHolidays(country, regionCode, year))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, regionCode, year))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month)
        {
            foreach (var answer in GetFixedHolidays(country, regionCode, year, month))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, regionCode, year, month))
                yield return answer;
        }

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(country, regionCode, year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, regionCode, year, month, day))
                yield return answer;
        }
    }
}