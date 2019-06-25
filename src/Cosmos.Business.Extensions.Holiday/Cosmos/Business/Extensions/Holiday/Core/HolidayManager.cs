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
    internal static class HolidayManager
    {
        static HolidayManager()
        {
            _fixedDailyNodeTreeCache = new DailyNodeTree();
            _variableDailyCache = new VariableDailyCache(new VariableDailyNodeTree());
        }

        #region Fixed holiday

        // ReSharper disable once InconsistentNaming
        private static readonly DailyNodeTree _fixedDailyNodeTreeCache;

        #region Add FixedHolidayFunc

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

        #endregion Add FixedHolidayFunc

        #region Get FixedHolidayFunc

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

        #endregion Get FixedHolidayFunc

        #region Get FixedHolidays

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

        #endregion Get FixedHolidays

        #endregion Fixed holiday

        #region Variable holiday

        // ReSharper disable once InconsistentNaming
        private static readonly VariableDailyCache _variableDailyCache;

        #region Add VariableHolidayFunc

        /// <summary>
        /// Add <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func"></param>
        public static void Add(IVariableHolidayFunc func)
        {
            _variableDailyCache.ExposeRoot.Add(func);
        }

        /// <summary>
        /// Add a collection of <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcs"></param>
        public static void AdRange(IEnumerable<IVariableHolidayFunc> funcs)
        {
            _variableDailyCache.ExposeRoot.AddRange(funcs);
        }

        #endregion

        #region Get VariableHolidayFunc

        /// <summary>
        /// Get all variable holiday func
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs()
        {
            return _variableDailyCache.ExposeRoot.Get();
        }

        /// <summary>
        /// Get all variable holiday func by special year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(int year)
        {
            return _variableDailyCache.ExposeRoot.Get(year);
        }

        /// <summary>
        /// Get all variable holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(CountryCode code)
        {
            return _variableDailyCache.ExposeRoot.Get(code);
        }

        /// <summary>
        /// Get all variable holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(Country country)
        {
            return _variableDailyCache.ExposeRoot.Get(country);
        }

        /// <summary>
        /// Get all variable holiday func by special country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(CountryCode code, string regionCode)
        {
            return _variableDailyCache.ExposeRoot.Get(code, regionCode);
        }

        /// <summary>
        /// Get all variable holiday func by special country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(Country country, string regionCode)
        {
            return _variableDailyCache.ExposeRoot.Get(country, regionCode);
        }

        /// <summary>
        /// Get all variable holiday func by special year and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(CountryCode code, int year)
        {
            return _variableDailyCache.ExposeRoot.Get(code, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(Country country, int year)
        {
            return _variableDailyCache.ExposeRoot.Get(country, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year, country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(CountryCode code, string regionCode, int year)
        {
            return _variableDailyCache.ExposeRoot.Get(code, regionCode, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IVariableHolidayFunc> GetVariableHolidayFuncs(Country country, string regionCode, int year)
        {
            return _variableDailyCache.ExposeRoot.Get(country, regionCode, year);
        }

        #endregion Get VariableHolidayFunc

        #region Get VariableHolidays

        public static IEnumerable<DailyAnswer> GetVariableHolidays(int year)
        {
            return _variableDailyCache.Get(year);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month)
        {
            return _variableDailyCache.Get(year, month);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month, int day)
        {
            return _variableDailyCache.Get(year, month, day);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year)
        {
            return _variableDailyCache.Get(code, year);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year)
        {
            return _variableDailyCache.Get(country.ToCode(), year);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year)
        {
            return _variableDailyCache.Get(code, regionCode, year);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year)
        {
            return _variableDailyCache.Get(country.ToCode(), regionCode, year);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month)
        {
            return _variableDailyCache.Get(code, year, month);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month)
        {
            return _variableDailyCache.Get(country.ToCode(), year, month);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month)
        {
            return _variableDailyCache.Get(code, regionCode, year, month);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month)
        {
            return _variableDailyCache.Get(country.ToCode(), regionCode, year, month);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month, int day)
        {
            return _variableDailyCache.Get(code, year, month, day);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month, int day)
        {
            return _variableDailyCache.Get(country.ToCode(), year, month, day);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _variableDailyCache.Get(code, regionCode, year, month, day);
        }

        public static IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month, int day)
        {
            return _variableDailyCache.Get(country.ToCode(), regionCode, year, month, day);
        }

        #endregion Get VariableHolidays

        #endregion Variable holiday

        #region Mixed getter

        /// <summary>
        /// Gets mixed <see cref="DailyAnswer"/> collection with <see cref="IFixedHolidayFunc"/> and <see cref="IVariableHolidayFunc"/> one.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DailyAnswer> GetHolidays(int year)
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
        public static IEnumerable<DailyAnswer> GetHolidays(int year, int month)
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
        public static IEnumerable<DailyAnswer> GetHolidays(int year, int month, int day)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, int year, int month, int day)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, int year)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, int year, int month, int day)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month)
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
        public static IEnumerable<DailyAnswer> GetHolidays(CountryCode code, string regionCode, int year, int month, int day)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month)
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
        public static IEnumerable<DailyAnswer> GetHolidays(Country country, string regionCode, int year, int month, int day)
        {
            foreach (var answer in GetFixedHolidays(country, regionCode, year, month, day))
                yield return answer;
            foreach (var answer in GetVariableHolidays(country, regionCode, year, month, day))
                yield return answer;
        }

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