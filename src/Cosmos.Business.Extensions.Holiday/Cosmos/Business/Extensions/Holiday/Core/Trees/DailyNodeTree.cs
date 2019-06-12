using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// 用于 FixedHoliday 模式的节点树
    /// </summary>
    public class DailyNodeTree
    {
        private readonly CountryCode _code;

        private readonly Dictionary<int, DailyNode> _monthDictionary;

        public DailyNodeTree(CountryCode code)
        {
            _code = code;
            _monthDictionary = new Dictionary<int, DailyNode>();

            var months = Numbers.GetMembersBetween(1, 12);
            foreach (var month in months)
                _monthDictionary.Add(month, new DailyNode());
        }

        /// <summary>
        /// Get <see cref="CountryInfo"/> of this <see cref="DailyNodeTree"/>.
        /// </summary>
        /// <returns></returns>
        public CountryInfo GetCountryInfo() => CountryManager.GetCountryInfo(_code);

        /// <summary>
        /// Get an instance of <see cref="DailyNode"/>.
        /// </summary>
        /// <param name="month">Special month</param>
        /// <returns><see cref="DailyNode"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of month should be between 1 and 12.</exception>
        public DailyNode GetDailyNode(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            return _monthDictionary[month];
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special month.
        /// </summary>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of month should be between 1 and 12.</exception>
        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            return GetDailyNode(month).GetFuncs();
        }

        /// <summary> 
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year and month.
        /// </summary>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of month should be between 1 and 12.</exception>
        /// <exception cref="ArgumentException">Invalid date in func.</exception>
        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, 1, out var dateInfo))
                throw new ArgumentException($"Invalid date: {year}-{month}");
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IFixedHolidayFunc"/> by special year, month and day. 
        /// </summary>
        /// <param name="year">Special year</param>
        /// <param name="month">Special month</param>
        /// <param name="day">Special day</param>
        /// <returns>A readonly list of <see cref="IFixedHolidayFunc"/></returns>
        /// <exception cref="ArgumentOutOfRangeException">The value of month should be between 1 and 12.</exception>
        /// <exception cref="ArgumentException">Invalid date in func.</exception>
        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month, int day)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, day, out var dateInfo))
                throw new ArgumentException($"Invalid date: {year}-{month}-{day}");
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentException">Country code of this func should be same as <see cref="DailyNodeTree"/>.</exception>
        public void AddFixedHolidayFunc(IFixedHolidayFunc func)
        {
            var code = func.Country.ToCode();
            if (_code != code)
                throw new ArgumentException($"Country code {code} must be {_code}.");

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

            foreach (var month in targetMonths.Where(x => x >= 1 && x <= 12))
            {
                _monthDictionary[month].Add(func);
            }
        }
    }
}