using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// 用于 FixedHoliday 模式的节点树
    /// </summary>
    public class DailyNodeTree
    {
        private readonly Dictionary<int, DailyNode> _monthDictionary;

        public DailyNodeTree()
        {
            _monthDictionary = new Dictionary<int, DailyNode>();

            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
                _monthDictionary.Add(month, new DailyNode());
        }

        #region Get DailyNode

        /// <summary>
        /// Get an instance of <see cref="DailyNode"/>.
        /// </summary>
        /// <param name="month">Special month</param>
        /// <returns><see cref="DailyNode"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of month should be between 1 and 12.</exception>
        private DailyNode GetDailyNode(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            return _monthDictionary[month];
        }

        #endregion

        #region Get FixedHolidayFunc readonly collection

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(int month)
        {
            CheckDate(month);
            return GetDailyNode(month).GetFuncs();
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, int month)
        {
            CheckDate(month);
            return GetDailyNode(month).GetFuncs(code);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, int month)
        {
            CheckDate(month);
            return GetDailyNode(month).GetFuncs(country);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int month)
        {
            CheckDate(month);
            return GetDailyNode(month).GetFuncs(code, regionCode);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, string regionCode, int month)
        {
            CheckDate(month);
            return GetDailyNode(month).GetFuncs(country, regionCode);
        }

        private void CheckDate(int month)
        {
            if (month > 12 || month < 1)
                throw new DateTimeOutOfRangeException($"The value of {month} should be between 1 and 12.");
        }

        /// <summary> 
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(int year, int month)
        {
            CheckDate(year, month, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, int year, int month)
        {
            CheckDate(year, month, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(code, dateInfo.Year, dateInfo.Month);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, int year, int month)
        {
            CheckDate(year, month, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(country, dateInfo.Year, dateInfo.Month);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int year, int month)
        {
            CheckDate(year, month, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(code, regionCode, dateInfo.Year, dateInfo.Month);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, string regionCode, int year, int month)
        {
            CheckDate(year, month, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(country, regionCode, dateInfo.Year, dateInfo.Month);
        }

        private void CheckDate(int year, int month, out DateInfo dateInfo)
        {
            if (month > 12 || month < 1)
                throw new DateTimeOutOfRangeException($"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, 1, out dateInfo))
                throw new InvalidDateTimeException($"Invalid date: {year}-{month}");
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(int year, int month, int day)
        {
            CheckDate(year, month, day, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, int year, int month, int day)
        {
            CheckDate(year, month, day, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(code, dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, int year, int month, int day)
        {
            CheckDate(year, month, day, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(country, dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(CountryCode code, string regionCode, int year, int month, int day)
        {
            CheckDate(year, month, day, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(code, regionCode, dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        public IReadOnlyList<IFixedHolidayFunc> Get(Country country, string regionCode, int year, int month, int day)
        {
            CheckDate(year, month, day, out var dateInfo);
            return GetDailyNode(dateInfo.Month).GetFuncs(country, regionCode, dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        private void CheckDate(int year, int month, int day, out DateInfo dateInfo)
        {
            if (month > 12 || month < 1)
                throw new DateTimeOutOfRangeException($"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, day, out dateInfo))
                throw new InvalidDateTimeException($"Invalid date: {year}-{month}-{day}");
        }

        #endregion

        #region Get DailyAnswer collection

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(int year, int month)
        {
            foreach (var func in Get(year, month))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, int year, int month)
        {
            foreach (var func in Get(code, year, month))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, int year, int month)
        {
            foreach (var func in Get(country, year, month))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionName"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, string regionName, int year, int month)
        {
            foreach (var func in Get(code, regionName, year, month))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionName"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, string regionName, int year, int month)
        {
            foreach (var func in Get(country, regionName, year, month))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(int year, int month, int day)
        {
            foreach (var func in Get(year, month, day))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, int year, int month, int day)
        {
            foreach (var func in Get(code, year, month, day))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, int year, int month, int day)
        {
            foreach (var func in Get(country, year, month, day))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionName"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, string regionName, int year, int month, int day)
        {
            foreach (var func in Get(code, regionName, year, month, day))
                yield return func.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionName"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, string regionName, int year, int month, int day)
        {
            foreach (var func in Get(country, regionName, year, month, day))
                yield return func.ToDailyAnswer(year);
        }

        #endregion

        #region Get DailyAnswer collection by indexer
        
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public IEnumerable<DailyAnswer> this[int year, int month] => GetDailyAnswers(year, month);
       
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public IEnumerable<DailyAnswer> this[CountryCode code, int year, int month] => GetDailyAnswers(code, year, month);
      
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public IEnumerable<DailyAnswer> this[Country country, int year, int month] => GetDailyAnswers(country, year, month);
       
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public IEnumerable<DailyAnswer> this[CountryCode code, string regionCode, int year, int month] => GetDailyAnswers(code, regionCode, year, month);
    
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and month.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public IEnumerable<DailyAnswer> this[Country country, string regionCode, int year, int month] => GetDailyAnswers(country, regionCode, year, month);
      
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public IEnumerable<DailyAnswer> this[int year, int month, int day] => GetDailyAnswers(year, month, day);
      
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public IEnumerable<DailyAnswer> this[CountryCode code, int year, int month, int day] => GetDailyAnswers(code, year, month, day);
       
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public IEnumerable<DailyAnswer> this[Country country, int year, int month, int day] => GetDailyAnswers(country, year, month, day);
      
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public IEnumerable<DailyAnswer> this[CountryCode code, string regionCode, int year, int month, int day] => GetDailyAnswers(code, regionCode, year, month, day);
      
        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, month and day.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        public IEnumerable<DailyAnswer> this[Country country, string regionCode, int year, int month, int day] => GetDailyAnswers(country, regionCode, year, month, day);

        #endregion

        #region Add / AddRange

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/>.<br />
        /// 添加 <see cref="IFixedHolidayFunc"/>。
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentException">Country code of this func should be same as <see cref="DailyNodeTree"/>.</exception>
        public void Add(IFixedHolidayFunc func)
        {
            if (func == null)
                return;
            foreach (var month in GetTargetMonths(func))
                _monthDictionary[month].Add(func);
        }

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/>.<br />
        /// 添加 <see cref="IFixedHolidayFunc"/>。
        /// </summary>
        /// <param name="funcFunc">To get an instance of <see cref="IFixedHolidayFunc"/>.</param>
        public void Add(Func<IFixedHolidayFunc> funcFunc)
        {
            Add(funcFunc?.Invoke());
        }

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> collection.<br />
        /// 添加 <see cref="IFixedHolidayFunc"/> 集合。
        /// </summary>
        /// <param name="funcs">An instance collection of <see cref="IFixedHolidayFunc"/>.</param>
        public void AddRange(IEnumerable<IFixedHolidayFunc> funcs)
        {
            if (funcs == null)
                return;
            foreach (var func in funcs)
                Add(func);
        }

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> collection.<br />
        /// 添加 <see cref="IFixedHolidayFunc"/> 集合。
        /// </summary>
        /// <param name="funcsFunc">To get an instance collection of <see cref="IFixedHolidayFunc"/>.</param>
        public void AddRange(Func<IEnumerable<IFixedHolidayFunc>> funcsFunc)
        {
            AddRange(funcsFunc?.Invoke());
        }

        private static IEnumerable<int> GetTargetMonths(IFixedHolidayFunc func)
        {
            var targetMonths = new List<int>();

            if (func.FromDate.HasValue && func.ToDate.HasValue)
            {
                var fromMonth = func.FromDate.Value.Month;
                var toMonth = func.ToDate.Value.Month;

                if (fromMonth > toMonth)
                {
                    targetMonths.AddRange(Numbers.GetMembersBetween(1, toMonth));
                    targetMonths.AddRange(Numbers.GetMembersBetween(fromMonth, 12));
                }
                else
                {
                    targetMonths.AddRange(Numbers.GetMembersBetween(fromMonth, toMonth));
                }
            }
            else
            {
                targetMonths.Add(func.Month);
            }

            return targetMonths.Where(x => x >= 1 && x <= 12);
        }

        #endregion

    }
}