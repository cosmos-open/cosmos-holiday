using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// Daily node
    /// </summary>
    public class DailyNode
    {
        private readonly List<IFixedHolidayFunc> _fixedHolidayFuncs;

        /// <summary>
        /// Create a new instance of <see cref="DailyNode"/>
        /// </summary>
        public DailyNode()
        {
            _fixedHolidayFuncs = new List<IFixedHolidayFunc>();
        }

        #region GetFuncs

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs()
        {
            return _fixedHolidayFuncs.AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code)
        {
            return GetFuncs(code.ToCountry());
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country)
        {
            return _fixedHolidayFuncs
                .Where(f => f.BelongsToCountry == country || f.Country == country)
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, string regionCode)
        {
            return GetFuncs(code.ToCountry(), regionCode);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, string regionCode)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.BelongsToCountry == country || f.Country == country) && f.MatchRegion(regionCode))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, int year)
        {
            return GetFuncs(code.ToCountry(), year);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, int year)
        {
            return _fixedHolidayFuncs
                .Where(f => f.BelongsToCountry == country || f.Country == country)
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, string regionCode, int year)
        {
            return GetFuncs(code.ToCountry(), regionCode, year);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, string regionCode, int year)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.BelongsToCountry == country || f.Country == country) && f.MatchRegion(regionCode))
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year, int month)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, int year, int month)
        {
            return GetFuncs(code.ToCountry(), year, month);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, int year, int month)
        {
            return _fixedHolidayFuncs
                .Where(f => f.BelongsToCountry == country || f.Country == country)
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, string regionCode, int year, int month)
        {
            return GetFuncs(code.ToCountry(), regionCode, year, month);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, string regionCode, int year, int month)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.BelongsToCountry == country || f.Country == country) && f.MatchRegion(regionCode))
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year, int month, int day)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month, day))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, int year, int month, int day)
        {
            return GetFuncs(code.ToCountry(), year, month, day);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, int year, int month, int day)
        {
            return _fixedHolidayFuncs
                .Where(f => f.BelongsToCountry == country || f.Country == country)
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month, day))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(CountryCode code, string regionCode, int year, int month, int day)
        {
            return GetFuncs(code.ToCountry(), regionCode, year, month, day);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IFixedHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(Country country, string regionCode, int year, int month, int day)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.BelongsToCountry == country || f.Country == country) && f.MatchRegion(regionCode))
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month, day))
                .ToList()
                .AsReadOnly();
        }

        #endregion

        #region Add

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="func"></param>
        public void Add(IFixedHolidayFunc func)
        {
            if (func == null)
                return;

            if (Contains(func))
                return;

            _fixedHolidayFuncs.Add(func);
        }

        #endregion

        #region Contains

        /// <summary>
        /// Contains<br />
        /// 包含
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <returns></returns>
        public bool Contains(IFixedHolidayFunc func)
        {
            if (func == null)
                return false;

            if (_fixedHolidayFuncs.Any(x => x.I18NIdentityCode == func.I18NIdentityCode))
                return true;

            if (_fixedHolidayFuncs.Any(x => x.Name == func.Name && x.Country == func.Country && x.BelongsToCountry == func.BelongsToCountry))
                return true;

//            if (func.FromDate.HasValue && func.ToDate.HasValue)
//            {
//                if (_fixedHolidayFuncs
//                    .Where(x => x.FromDate.HasValue && x.ToDate.HasValue)
//                    .Any(x =>
//                        x.FromDate.Value.Month == func.FromDate.Value.Month && x.FromDate.Value.Day == func.FromDate.Value.Day &&
//                        x.ToDate.Value.Month == func.ToDate.Value.Month && x.ToDate.Value.Day == func.ToDate.Value.Day))
//                    return true;
//            }
//            else
//            {
//                if (_fixedHolidayFuncs
//                    .Where(x => !x.FromDate.HasValue && !x.ToDate.HasValue)
//                    .Any(x => x.Month == func.Month && x.Day == func.Day))
//                    return true;
//            }

            return false;
        }

        #endregion

    }
}