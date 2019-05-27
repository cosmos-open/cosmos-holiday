using System;
using System.Collections.Generic;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    public class HolidayInfo : DateInfo, IHolidayInfo
    {
        public HolidayInfo(string name, DateTime dt) : this(name, dt.Year, dt.Month, dt.Day) { }

        public HolidayInfo(string name, DateInfo di) : this(name, di.Year, di.Month, di.Day) { }

        public HolidayInfo(HolidayInfo hi) : this(hi.Name, (DateInfo) hi) { }

        public HolidayInfo(string name, int year, int month, int day) : base(year, month, day)
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

        public int Length => 1;

        public IEnumerable<HolidayInfo> GetAllDates() => new[] {this};

        public bool IsRestDay { get; private set; }


        /// <summary>
        /// 节日开始的年份
        /// </summary>
        public int? LaunchYear { get; set; }
    }
}