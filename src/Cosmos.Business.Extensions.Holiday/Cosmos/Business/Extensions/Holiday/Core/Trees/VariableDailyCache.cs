using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// Variable Daily Cache
    /// </summary>
    public class VariableDailyCache
    {
        private readonly VariableDailyNodeTree _root;
        private readonly Dictionary<(CountryCode Code, int Year), List<DailyAnswer>> _cache;
        private readonly Dictionary<CountryCode, List<int>> _cacheKeys;
        private readonly object _lockObj = new object();

        /// <summary>
        /// Create a new instance of <see cref="VariableDailyCache"/>
        /// </summary>
        /// <param name="root"></param>
        public VariableDailyCache(VariableDailyNodeTree root)
        {
            _root = root ?? throw new ArgumentNullException(nameof(root));
            _cache = new Dictionary<(CountryCode Code, int Year), List<DailyAnswer>>();
            _cacheKeys = new Dictionary<CountryCode, List<int>>();
        }

        #region Get and cache DailyAnswer collection

        /// <summary>
        /// Caches and gets DailyAnswer collection via special year.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(int year)
        {
            var countryCodes = _cacheKeys.Where(x => x.Value.Contains(year)).Select(x => x.Key);
            foreach (var code in countryCodes)
            foreach (var answer in Get(code, year))
                if (answer != null)
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(int year, int month)
        {
            var answers = Get(year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special year, month and day.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(int year, int month, int day)
        {
            var answers = Get(year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month, day))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code and year.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, int year)
        {
            var key = (code, year);

            lock (_lockObj)
            {
                if (_cache.ContainsKey(key))
                    return _cache[key];

                var answers = _root.GetDailyAnswers(code, year)
                    .Where(answer => answer != null && answer.Match(year))
                    .ToList();
                _cache.Add(key, answers);

                if (_cacheKeys.TryGetValue(code, out var years))
                {
                    if (!years.Contains(year))
                        years.Add(year);
                }
                else
                {
                    years = new List<int> {year};
                    _cacheKeys.Add(code, years);
                }

                return answers;
            }
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code, year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, int year, int month)
        {
            var answers = Get(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code, year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, int year, int month, int day)
        {
            var answers = Get(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month, day))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code, region code and year.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, string regionCode, int year)
        {
            var answers = Get(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code, region code, year and month.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, string regionCode, int year, int month)
        {
            var answers = Get(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year, month))
                    yield return answer;
        }

        /// <summary>
        /// Caches and gets DailyAnswer collection via special country code, region code, year, month and day.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> Get(CountryCode code, string regionCode, int year, int month, int day)
        {
            var answers = Get(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year, month, day))
                    yield return answer;
        }

        #endregion Get and cache DailyAnswer collection

        #region Get DailyAnswer collection without cache

        /// <summary>
        /// Gets DailyAnswer collection via special country code and year without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, int year)
        {
            var answers = _root.GetDailyAnswers(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year))
                    yield return answer;
        }

        /// <summary>
        /// Gets DailyAnswer collection via special country code, year and month without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, int year, int month)
        {
            var answers = _root.GetDailyAnswers(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month))
                    yield return answer;
        }

        /// <summary>
        /// Gets DailyAnswer collection via special country code, year month and day month without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, int year, int month, int day)
        {
            var answers = _root.GetDailyAnswers(code, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(year, month, day))
                    yield return answer;
        }

        /// <summary>
        /// Gets DailyAnswer collection via special country code, region code and year without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, string regionCode, int year)
        {
            var answers = _root.GetDailyAnswers(code, regionCode, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year))
                    yield return answer;
        }

        /// <summary>
        /// Gets DailyAnswer collection via special country code, region code, year and month without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, string regionCode, int year, int month)
        {
            var answers = _root.GetDailyAnswers(code, regionCode, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year, month))
                    yield return answer;
        }

        /// <summary>
        /// Gets DailyAnswer collection via special country code, region code, year, month and day without cache.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetWithoutCache(CountryCode code, string regionCode, int year, int month, int day)
        {
            var answers = _root.GetDailyAnswers(code, regionCode, year);
            foreach (var answer in answers)
                if (answer != null && answer.Match(regionCode) && answer.Match(year, month, day))
                    yield return answer;
        }

        #endregion

        #region Root

        /// <summary>
        /// Gets root
        /// </summary>
        public VariableDailyNodeTree ExposeRoot => _root;

        #endregion Root

        #region Flush

        /// <summary>
        /// Flush cache
        /// </summary>
        public void Flush()
        {
            lock (_lockObj)
            {
                _cache.Clear();
            }
        }

        /// <summary>
        /// Flush cache
        /// </summary>
        /// <param name="code"></param>
        public void Flush(CountryCode code)
        {
            lock (_lockObj)
            {
                if (_cacheKeys.TryGetValue(code, out var years))
                {
                    foreach (var year in years)
                        _cache.Remove((code, year));
                    _cacheKeys.Remove(code);
                }
            }
        }

        /// <summary>
        /// Flush cache
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        public void Flush(CountryCode code, int year)
        {
            lock (_lockObj)
            {
                _cache.Remove((code, year));
                if (_cacheKeys.TryGetValue(code, out var list))
                    list.Remove(year);
            }
        }

        #endregion Flush

    }
}