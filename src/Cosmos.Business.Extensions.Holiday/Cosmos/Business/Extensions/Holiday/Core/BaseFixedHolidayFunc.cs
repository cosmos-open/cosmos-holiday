using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Date;
using Cosmos.I18N.Countries;
using Cosmos.Joiners;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Basic fixed holiday func
    /// </summary>
    public abstract class BaseFixedHolidayFunc : IFixedHolidayFunc
    {

        #region Country and region

        /// <summary>
        /// Country or region
        /// <br />
        /// 标记对应的国家或地区
        /// </summary>
        public abstract Country Country { get; }

        /// <summary>
        /// Belongs to country
        /// <br />
        /// 标记该国家或地区的所属国家
        /// </summary>
        public abstract Country BelongsToCountry { get; }

        /// <summary>
        /// Region code
        /// <br />
        /// 標記对应地区的名称，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 Country 枚举的 Name 值
        /// </summary>
        public virtual string RegionCode { get; } = string.Empty;

        /// <summary>
        /// A list of region code
        /// <br />
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

        /// <summary>
        /// Match region code
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Name
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Type of holiday
        /// </summary>
        // ReSharper disable once UnusedMember.Global
        public abstract HolidayType HolidayType { get; set; }

        #endregion

        #region Date

        /// <summary>
        /// Month
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public virtual int Month { get; set; }

        /// <summary>
        /// Day
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public virtual int Day { get; set; }

        /// <summary>
        /// From date...
        /// </summary>
        public virtual (int Month, int Day)? FromDate { get; set; }

        /// <summary>
        /// To date...
        /// </summary>
        public virtual (int Month, int Day)? ToDate { get; set; }

        /// <summary>
        /// Length of holiday
        /// <br />
        /// 节日长度，默认为 1 天
        /// </summary>
        public virtual int Length { get; } = 1;

        /// <summary>
        /// Match date
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public virtual bool MatchDate(int month)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, ToDate.Value.Month, month);

            return Month == month;
        }

        /// <summary>
        /// Match date
        /// </summary>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public virtual bool MatchDate(int month, int day)
        {
            if (FromDate.HasValue && ToDate.HasValue)
                return MonthHelper.In(FromDate.Value.Month, FromDate.Value.Day, ToDate.Value.Month, ToDate.Value.Day, month, day);

            return Month == month && Day == day;
        }

        #endregion

        #region Scince and end

        /// <summary>
        /// Since...
        /// </summary>
        public virtual int? Since { get; set; } = null;

        /// <summary>
        /// End...
        /// </summary>
        public virtual int? End { get; set; } = null;

        /// <summary>
        /// Time step value...
        /// </summary>
        public virtual int? TimeStepValue { get; } = null;

        private int? OneOnlyYear { get; set; }

        /// <summary>
        /// One-time holiday...
        /// </summary>
        protected virtual int? OnlyYear
        {
            get => OneOnlyYear;
            set
            {
                OneOnlyYear = value;
                Since = OneOnlyYear;
                End = OneOnlyYear;
            }
        }

        #endregion

        #region I18N

        /// <summary>
        /// i18n identity code
        /// </summary>
        public abstract string I18NIdentityCode { get; }

        /// <summary>
        /// Globalization Key
        /// </summary>
        public virtual string GlobalizationKey
            => FromDate.HasValue
                ? $"{MayZero(FromDate.Value.Month)}-{MayZero(FromDate.Value.Day)}"
                : $"{MayZero(Month)}-{MayZero(Day)}";

        private static string MayZero(int value) => (100 + value).ToString().Right(2);

        #endregion

        #region to daily answer

        /// <summary>
        /// Convet to <see cref="DailyAnswer"/>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public virtual DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name, HolidayType);

            if (!FromDate.HasValue && !ToDate.HasValue)
                builder.From(year, Month, Day);
            else if (FromDate.HasValue && !ToDate.HasValue)
                builder.From(year, FromDate.Value);
            else if (FromDate.HasValue)
                builder.From(year, FromDate.Value).To(year, ToDate.Value);
            else
                throw new InvalidDateTimeException("Invalid datetime when convert holiday definition to DailyAnswer.");

            if (!FromDate.HasValue && !ToDate.HasValue && Length > 1)
                builder.To(DateTimeFactory.Create(year, Month, Day).AddDays(Length - 1));

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

        #endregion

    }
}