using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    public class PeriodHolidayInfo : PeriodDateInfo<HolidayInfo>, IHolidayInfo
    {
        public PeriodHolidayInfo(string name, HolidayInfo from, HolidayInfo to) : base(from, to, h => h.Clone())
        {
            Name = name;
        }

        public string Name { get; }

        public string LocalName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2
        /// </summary>
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2
        /// </summary>
        public CountryCode BelongsToCountryCode { get; set; }

        public override HolidayInfo From => _from.Clone();

        public override HolidayInfo To => _to.Clone();

        public bool IsRestDay { get; private set; }
        
        /// <summary>
        /// 节日开始的年份
        /// </summary>
        public  int? LaunchYear{get; set; }
    }
}