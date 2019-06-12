using System.Collections.Generic;
using System.Linq;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    public class DailyNode
    {
        private readonly List<IFixedHolidayFunc> _fixedHolidayFuncs;

        public DailyNode()
        {
            _fixedHolidayFuncs = new List<IFixedHolidayFunc>();
        }

        public IReadOnlyList<IFixedHolidayFunc> GetFuncs() =>
            _fixedHolidayFuncs.AsReadOnly();

        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year) =>
            _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();

        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year, int month)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month))
                .ToList()
                .AsReadOnly();
        }

        public IReadOnlyList<IFixedHolidayFunc> GetFuncs(int year, int month, int day)
        {
            return _fixedHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .Where(f => f.MatchDate(month, day))
                .ToList()
                .AsReadOnly();
        }

        public void Add(IFixedHolidayFunc func)
        {
            if (Contains(func))
                return;
            _fixedHolidayFuncs.Add(func);
        }

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="func">An instance of <see cref="IFixedHolidayFunc"/>.</param>
        /// <returns></returns>
        public bool Contains(IFixedHolidayFunc func)
        {
            if (func == null)
                return false;

            if (_fixedHolidayFuncs.Any(x => x.Name == func.Name || x.I18NIdentityCode == func.I18NIdentityCode))
                return true;

            if (func.FromDate.HasValue && func.ToDate.HasValue)
            {
                if (_fixedHolidayFuncs
                    .Where(x => x.FromDate.HasValue && x.ToDate.HasValue)
                    .Any(x =>
                        x.FromDate.Value.Month == func.FromDate.Value.Month && x.FromDate.Value.Day == func.FromDate.Value.Day &&
                        x.ToDate.Value.Month == func.ToDate.Value.Month && x.ToDate.Value.Day == func.ToDate.Value.Day))
                    return true;
            }
            else
            {
                if (_fixedHolidayFuncs
                    .Where(x => !x.FromDate.HasValue && !x.ToDate.HasValue)
                    .Any(x => x.Month == func.Month && x.Day == func.Day))
                    return true;
            }

            return false;
        }
    }
}