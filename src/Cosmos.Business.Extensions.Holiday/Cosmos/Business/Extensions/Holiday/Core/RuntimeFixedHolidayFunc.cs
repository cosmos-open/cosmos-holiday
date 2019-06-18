using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// 运行时动态生成的 FixedHolidayFunc，用于基于配置生成固定节日
    /// </summary>
    public class RuntimeFixedHolidayFunc : IFixedHolidayFunc
    {
        public Country Country { get; set; }

        public Country BelongsToCountry { get; set; }
        
        public virtual string RegionCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets real region's code.<br />
        /// 获取真实的地区编码。<br />
        /// If <see cref="RegionCode"/> is empty, returns the name of <see cref="CountryCode"/> witch converted from <see cref="Country"/>.<br />
        /// 如果地区编码 <see cref="RegionCode"/> 为空，则返回转换自 <see cref="Country"/> 的 <see cref="CountryCode"/> 的名称。<br />
        /// <br />
        /// If this holiday belongs to the whole nation, returns empty.<br />
        /// 如果本节日属于国家级的节日（非地区级别的），则返回空 empty。
        /// </summary>
        /// <returns></returns>
        public virtual string GetRegionName()
        {
            return string.IsNullOrWhiteSpace(RegionCode)
                ? EnumsNET.Enums.GetName(Country.ToCode())
                : RegionCode;
        }

        public string Name { get; set; }

        public HolidayType HolidayType { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public (int Month, int Day)? FromDate { get; set; }

        public (int Month, int Day)? ToDate { get; set; }

        public bool MatchDate(int month)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, ToDate.Value.Month, month);

            return Month == month;
        }

        public bool MatchDate(int month, int day)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, FromDate.Value.Day, ToDate.Value.Month, ToDate.Value.Day, month, day);

            return Month == month && Day == day;
        }

        public string I18NIdentityCode { get; set; }

        public int? Since { get; set; }

        public int? End { get; set; }

        public int? TimeStepValue { get; set; }

        public DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name).From(year, Month, Day);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            return builder.Build(year);
        }
    }
}