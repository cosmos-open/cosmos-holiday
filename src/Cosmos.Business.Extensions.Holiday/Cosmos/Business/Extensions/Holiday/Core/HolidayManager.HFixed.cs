using System;
using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday Manager
    /// </summary>
    public partial class HolidayManager
    {

        #region Add

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentNullException">The instance of <see cref="IFixedHolidayFunc"/> func should not be null.</exception>
        /// <exception cref="InvalidOperationException">Failed to add <see cref="IFixedHolidayFunc"/> func.</exception>
        public void Add(IFixedHolidayFunc func)
        {
            _fixedDailyNodeTree.Add(func);
        }

        /// <summary>
        /// Add a collection of <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcColl"></param>
        public void AddRange(IEnumerable<IFixedHolidayFunc> funcColl)
        {
            _fixedDailyNodeTree.AddRange(funcColl);
        }

        #endregion Add

        #region Gets

        /// <summary>
        /// Get all fixed holiday func
        /// </summary>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get()
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTree.Get(month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTree.Get(code, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTree.Get(country, month);
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
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, string regionCode)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTree.Get(code, regionCode, month);
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
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, string regionCode)
        {
            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
            {
                var funcs = _fixedDailyNodeTree.Get(country, regionCode, month);
                foreach (var func in funcs)
                    yield return func;
            }
        }

        /// <summary>
        /// Get all fixed holiday func by special month
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(int month)
        {
            return _fixedDailyNodeTree.Get(month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, int month)
        {
            return _fixedDailyNodeTree.Get(code, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, int month)
        {
            return _fixedDailyNodeTree.Get(country, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month, country coed and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, string regionCode, int month)
        {
            return _fixedDailyNodeTree.Get(code, regionCode, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special month, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, string regionCode, int month)
        {
            return _fixedDailyNodeTree.Get(country, regionCode, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(int year, int month)
        {
            return _fixedDailyNodeTree.Get(year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month and country code..
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, int year, int month)
        {
            return _fixedDailyNodeTree.Get(code, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, int year, int month)
        {
            return _fixedDailyNodeTree.Get(country, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTree.Get(code, regionCode, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTree.Get(country, regionCode, year, month);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month abd day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(int year, int month, int day)
        {
            return _fixedDailyNodeTree.Get(year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, int year, int month, int day)
        {
            return _fixedDailyNodeTree.Get(code, year, month, day);
        }

        /// <summary>
        /// Get all fixed holiday func by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, int year, int month, int day)
        {
            return _fixedDailyNodeTree.Get(country, year, month, day);
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
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTree.Get(code, regionCode, year, month, day);
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
        IEnumerable<IFixedHolidayFunc> IFixedHolidayManager.Get(Country country, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTree.Get(country, regionCode, year, month, day);
        }

        #endregion

        #region Gets DailyAnswer

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(int year)
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year)
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year)
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year)
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year)
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month)
        {
            return _fixedDailyNodeTree[year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month)
        {
            return _fixedDailyNodeTree[code, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month)
        {
            return _fixedDailyNodeTree[country, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country code and region code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTree[code, regionCode, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, country and region code.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month)
        {
            return _fixedDailyNodeTree[country, regionCode, year, month];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(int year, int month, int day)
        {
            return _fixedDailyNodeTree[year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country code.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, int year, int month, int day)
        {
            return _fixedDailyNodeTree[code, year, month, day];
        }

        /// <summary>
        /// Get all fixed holiday <see cref="DailyAnswer"/> instance by special year, month, day and country.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, int year, int month, int day)
        {
            return _fixedDailyNodeTree[country, year, month, day];
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTree[code, regionCode, year, month, day];
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
        public IEnumerable<DailyAnswer> GetFixedHolidays(Country country, string regionCode, int year, int month, int day)
        {
            return _fixedDailyNodeTree[country, regionCode, year, month, day];
        }

        #endregion

    }
}