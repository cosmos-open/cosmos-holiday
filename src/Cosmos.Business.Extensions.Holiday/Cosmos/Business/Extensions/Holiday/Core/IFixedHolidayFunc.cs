using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public interface IFixedHolidayFunc
    {

        #region Country and region

        /// <summary>
        /// 标记对应的国家或地区
        /// </summary>
        Country Country { get; }

        /// <summary>
        /// 标记该国家或地区的所属国家
        /// </summary>
        Country BelongsToCountry { get; }

        /// <summary>
        /// 標記对应地区的名称，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 Country 枚举的 Name 值
        /// </summary>
        string RegionCode { get; }

        /// <summary>
        /// 標記对应地区的名称列表，可为空。<br />
        /// 对于国家：请留空<br />
        /// 对于地区：如果留空，则将返回 RegionCode 的值
        /// </summary>
        List<string> RegionCodes { get; }

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
        string GetRegionCode();

        bool MatchRegion(string regionCode);

        #endregion

        #region Name and type

        /// <summary>
        /// 固定节日的名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 固定节日类型
        /// </summary>
        HolidayType HolidayType { get; }

        #endregion

        #region Date

        /// <summary>
        /// 固定节日的月份
        /// </summary>
        int Month { get; }

        /// <summary>
        /// 固定节日的日份
        /// </summary>
        int Day { get; }

        /// <summary>
        /// 固定节日的起始日期，优先级高于 Month 和 Day
        /// </summary>
        (int Month, int Day)? FromDate { get; set; }

        /// <summary>
        /// 固定节日的截止日期，优先级高于 Month 和 Day
        /// </summary>
        (int Month, int Day)? ToDate { get; set; }
        
        /// <summary>
        /// 节日长度
        /// </summary>
        int Length { get; }

        /// <summary>
        /// 用于判断指定月份是否命中本节日
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        bool MatchDate(int month);

        /// <summary>
        /// 用于判断指定月份和日份是否命中本节日
        /// </summary>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        bool MatchDate(int month, int day);

        #endregion

        #region Since and end

        /// <summary>
        /// 表示节日从何年开始生效（包含该年）
        /// </summary>
        int? Since { get; }

        /// <summary>
        /// 表示节日至何年起无效（包含该年
        /// </summary>
        int? End { get; }

        /// <summary>
        /// 计算届数时每届间隔的时间
        /// </summary>
        int? TimeStepValue { get; }

        #endregion


        /// <summary>
        /// I18N 识别码
        /// </summary>
        string I18NIdentityCode { get; }

        /// <summary>
        /// 转换为 DailyAnswer
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        DailyAnswer ToDailyAnswer(int year);
    }
}