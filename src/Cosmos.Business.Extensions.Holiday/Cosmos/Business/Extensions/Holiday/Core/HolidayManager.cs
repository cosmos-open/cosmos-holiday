using System;
using System.Collections.Concurrent;
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
            _fixedDailyNodeTrees = new ConcurrentDictionary<CountryCode, DailyNodeTree>();
        }

        #region Fixed holiday

        // ReSharper disable once InconsistentNaming
        private static readonly ConcurrentDictionary<CountryCode, DailyNodeTree> _fixedDailyNodeTrees;

        // ReSharper disable once InconsistentNaming
        private static readonly object _fixedLockObj = new object();

        /// <summary>
        /// Add <see cref="IFixedHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <exception cref="ArgumentNullException">The instance of <see cref="IFixedHolidayFunc"/> func should not be null.</exception>
        /// <exception cref="InvalidOperationException">Failed to add <see cref="IFixedHolidayFunc"/> func.</exception>
        public static void Add(IFixedHolidayFunc func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            var countryCode = func.Country.ToCode();
            lock (_fixedLockObj)
            {
                if (_fixedDailyNodeTrees.ContainsKey(countryCode))
                    return;

                var tree = new DailyNodeTree(countryCode);

                if (_fixedDailyNodeTrees.TryAdd(countryCode, tree))
                {
                    tree.AddFixedHolidayFunc(func);
                }
                else
                {
                    throw new InvalidOperationException($"Failed to add {typeof(IFixedHolidayFunc)}.");
                }
            }
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