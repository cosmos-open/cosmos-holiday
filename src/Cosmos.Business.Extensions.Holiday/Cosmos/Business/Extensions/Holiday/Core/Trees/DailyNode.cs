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
    }
}