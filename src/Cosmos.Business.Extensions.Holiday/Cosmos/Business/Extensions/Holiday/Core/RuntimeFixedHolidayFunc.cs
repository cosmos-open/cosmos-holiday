using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;
using Cosmos.Joiners;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// 运行时动态生成的 FixedHolidayFunc，用于基于配置生成固定节日
    /// </summary>
    public class RuntimeFixedHolidayFunc : IFixedHolidayFunc
    {

        #region Country and region

        /// <summary>
        /// 标记对应的国家或地区
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// 标记该国家或地区的所属国家
        /// </summary>
        public Country BelongsToCountry { get; set; }

        /// <summary>
        /// 標記对应地区的名称，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 Country 枚举的 Name 值
        /// </summary>
        public virtual string RegionCode { get; set; } = string.Empty;

        /// <summary>
        /// 標記对应地区的名称列表，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 RegionCode 的值
        /// </summary>
        public List<string> RegionCodes { get; set; } = new List<string>();

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
        public virtual string GetRegionCode()
        {
            if (RegionCodes.Any())
                return Joiner.On(',').Join(RegionCodes);
            return string.IsNullOrWhiteSpace(RegionCode)
                ? CountryHelper.GetRegionCode(Country, BelongsToCountry)
                : RegionCode;
        }

        public bool MatchRegion(string regionCode)
        {
            if (RegionCodes.Any())
                return RegionCodes.Contains(regionCode);
            if (!string.IsNullOrWhiteSpace(RegionCode))
                return RegionCode == regionCode;
            return CountryHelper.GetRegionCode(Country, BelongsToCountry) == regionCode;
        }

        #endregion

        #region Name and type

        public string Name { get; set; }

        public HolidayType HolidayType { get; set; }

        #endregion

        #region Date

        public int Month { get; set; }

        public int Day { get; set; }

        public (int Month, int Day)? FromDate { get; set; }

        public (int Month, int Day)? ToDate { get; set; }

        public int Length { get; set; } = 1;

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

        #endregion

        #region Since and end

        public int? Since { get; set; }

        public int? End { get; set; }

        public int? TimeStepValue { get; set; }

        #endregion


        public string I18NIdentityCode { get; set; }


        public DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name).From(year, Month, Day);

            if (Length > 1)
                builder.To(Length);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            return builder.I18N(I18NIdentityCode).Build(year);
        }
    }
}