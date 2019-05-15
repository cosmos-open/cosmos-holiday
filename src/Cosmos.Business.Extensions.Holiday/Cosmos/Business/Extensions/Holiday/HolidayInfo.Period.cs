using System.Collections.Generic;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Holiday
{
    public class PeriodHolidayInfo : PeriodDateInfo<HolidayInfo>, IHolidayInfo
    {
        private readonly IEnumerable<HolidayInfo> _allDateInfoList = new List<HolidayInfo>();

        public PeriodHolidayInfo(string name, HolidayInfo from, HolidayInfo to) : base(from, to, h => h.Clone())
        {
            Name = name;
        }

        public string Name { get; }

        public override HolidayInfo From => _from.Clone();

        public override HolidayInfo To => _to.Clone();

        public bool IsRestDay { get; private set; }
    }
}