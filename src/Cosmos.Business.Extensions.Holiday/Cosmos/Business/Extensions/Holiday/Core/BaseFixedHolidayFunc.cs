using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;
using Cosmos.Joiners;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class BaseFixedHolidayFunc : IFixedHolidayFunc
    {

        #region Country and region

        /// <summary>
        /// 标记对应的国家或地区
        /// </summary>
        public abstract Country Country { get; }

        /// <summary>
        /// 标记该国家或地区的所属国家
        /// </summary>
        public abstract Country BelongsToCountry { get; }

        /// <summary>
        /// 標記对应地区的名称，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 Country 枚举的 Name 值
        /// </summary>
        public virtual string RegionCode { get; } = string.Empty;

        /// <summary>
        /// 標記对应地区的名称列表，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 RegionCode 的值
        /// </summary>
        public virtual List<string> RegionCodes { get; set; } = new List<string>();

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
            return Joiner.On(',').Join(GetRegionCodeList());
        }

        private List<string> GetRegionCodeList()
        {
            if (RegionCodes.Any())
                return RegionCodes;
            return !string.IsNullOrWhiteSpace(RegionCode)
                ? new List<string> {RegionCode}
                : new List<string> {CountryHelper.GetRegionCode(Country, BelongsToCountry)};
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

        public abstract string Name { get; }

        public abstract HolidayType HolidayType { get; set; }

        #endregion

        #region Date

        public virtual int Month { get; set; }

        public virtual int Day { get; set; }

        public virtual (int Month, int Day)? FromDate { get; set; }

        public virtual (int Month, int Day)? ToDate { get; set; }

        /// <summary>
        /// 节日长度，默认为 1 天
        /// </summary>
        public virtual int Length { get; } = 1;

        public virtual bool MatchDate(int month)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, ToDate.Value.Month, month);

            return Month == month;
        }

        public virtual bool MatchDate(int month, int day)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, FromDate.Value.Day, ToDate.Value.Month, ToDate.Value.Day, month, day);

            return Month == month && Day == day;
        }

        #endregion

        #region Scince and end

        public virtual int? Since { get; } = null;

        public virtual int? End { get; } = null;

        public virtual int? TimeStepValue { get; } = null;

        #endregion

        #region I18N

        public abstract string I18NIdentityCode { get; }

        #endregion

        public virtual DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name).From(year, Month, Day);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.I18N(I18NIdentityCode);
            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.Build(year);
        }
    }
}