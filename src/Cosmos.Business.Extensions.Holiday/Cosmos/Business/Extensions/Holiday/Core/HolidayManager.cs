using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core.Trees;
using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday Manager
    /// </summary>
    internal static class HolidayManager
    {
        static HolidayManager()
        {
            _fixedDailyNodeTreeCache = new DailyNodeTree();
        }

        #region Fixed holiday

        // ReSharper disable once InconsistentNaming
        private static readonly DailyNodeTree _fixedDailyNodeTreeCache;

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentNullException">The instance of <see cref="IFixedHolidayFunc"/> func should not be null.</exception>
        /// <exception cref="InvalidOperationException">Failed to add <see cref="IFixedHolidayFunc"/> func.</exception>
        public static void Add(IFixedHolidayFunc func)
        {
            _fixedDailyNodeTreeCache.Add(func);
        }

        /// <summary>
        /// Add a collection of <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcs"></param>
        public static void AddRange(IEnumerable<IFixedHolidayFunc> funcs)
        {
            _fixedDailyNodeTreeCache.AddRange(funcs);
        }

        /// <summary>
        /// Get all fixed holiday func
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs()
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTreeCache.Get(month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTreeCache.Get(code, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTreeCache.Get(country, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, string regionCode)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTreeCache.Get(code, regionCode, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, string regionCode)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTreeCache.Get(country, regionCode, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special month
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(int month)
        {
            return _fixedDailyNodeTreeCache.Get(month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, int month)
        {
            return _fixedDailyNodeTreeCache.Get(code, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, int month)
        {
            return _fixedDailyNodeTreeCache.Get(country, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month, country coed and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, string regionCode, int month)
        {
            return _fixedDailyNodeTreeCache.Get(code, regionCode, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, string regionCode, int month)
        {
            return _fixedDailyNodeTreeCache.Get(country, regionCode, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month)
        {
            return _fixedDailyNodeTreeCache.Get(year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month and country code..
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, int year, int month)
        {
            return _fixedDailyNodeTreeCache.Get(code, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, int year, int month)
        {
            return _fixedDailyNodeTreeCache.Get(country, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTreeCache.Get(code, regionCode, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTreeCache.Get(country, regionCode, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month abd day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache.Get(year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache.Get(code, year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache.Get(country, year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, day, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache.Get(code, regionCode, year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month , day, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IFixedHolidayFunc> GetFixedHolidayFuncs(Country country, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache.Get(country, regionCode, year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(int year)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var answers = GetFixedHolidays(year, month);
                foreach (var answer in answers)
                    yield return answer;
            }
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var answers = GetFixedHolidays(code, year, month);
                foreach (var answer in answers)
                    yield return answer;
            }
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var answers = GetFixedHolidays(country, year, month);
                foreach (var answer in answers)
                    yield return answer;
            }
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var answers = GetFixedHolidays(code, regionCode, year, month);
                foreach (var answer in answers)
                    yield return answer;
            }
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var answers = GetFixedHolidays(country, regionCode, year, month);
                foreach (var answer in answers)
                    yield return answer;
            }
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month)
        {
            return _fixedDailyNodeTreeCache[year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month)
        {
            return _fixedDailyNodeTreeCache[code, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month)
        {
            return _fixedDailyNodeTreeCache[country, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTreeCache[code, regionCode, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTreeCache[country, regionCode, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache[year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache[code, year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache[country, year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache[code, regionCode, year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTreeCache[country, regionCode, year, month, day];
        }

        #endregion

        #region Variable holiday

        #endregion
        
        #region Weekends

        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IWeekendDictionary GetWeekendDictionary(CountryCode code)
            => WeekendManager.GetWeekendDictionary(code);

        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by weekend type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IWeekendDictionary GetWeekendDictionary(string type)
            => WeekendManager.GetWeekendDictionary(type);

        #endregion

    }
}