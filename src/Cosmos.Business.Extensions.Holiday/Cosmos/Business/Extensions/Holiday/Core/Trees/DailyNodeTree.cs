using System;
using System.Collections.Generic;
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
            _monthDictionary = new Dictionary<int, DailyNode>
            {
                {1, new DailyNode()},
                {2, new DailyNode()},
                {3, new DailyNode()},
                {4, new DailyNode()},
                {5, new DailyNode()},
                {6, new DailyNode()},
                {7, new DailyNode()},
                {8, new DailyNode()},
                {9, new DailyNode()},
                {10, new DailyNode()},
                {11, new DailyNode()},
                {12, new DailyNode()}
            };
        }

        public CountryInfo GetCountryInfo() => CountryManager.GetCountryInfo(_code);

        public DailyNode GetDailyNode(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            return _monthDictionary[month];
        }

        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            return GetDailyNode(month).GetFuncs();
        }

        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, 1, out var dateInfo))
                throw new ArgumentException($"Invalid date: {year}-{month}");
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month);
        }

        public IReadOnlyList<IFixedHolidayFunc> GetFixedHolidayFuncs(int year, int month, int day)
        {
            if (month > 12 || month < 1)
                throw new ArgumentOutOfRangeException(nameof(month), $"The value of {month} should be between 1 and 12.");
            if (!MonthHelper.DoesDayInMonth(year, month, day, out var dateInfo))
                throw new ArgumentException($"Invalid date: {year}-{month}-{day}");
            return GetDailyNode(dateInfo.Month).GetFuncs(dateInfo.Year, dateInfo.Month, dateInfo.Day);
        }
    }
}