using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    public interface IHolidayInfo
    {
        /// <summary>
        /// 英语节日名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 当地节日名称
        /// </summary>
        string LocalName { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2
        /// </summary>
        CountryCode CountryCode { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2
        /// </summary>
        CountryCode BelongsToCountryCode { get; set; }

        /// <summary>
        /// 节日长度
        /// </summary>
        int Length { get; }

        /// <summary>
        /// 返回节日的每一天
        /// </summary>
        /// <returns></returns>
        IEnumerable<HolidayInfo> GetAllDates();

        /// <summary>
        /// 标记是否为休息日
        /// </summary>
        bool IsRestDay { get; }
        
        /// <summary>
        /// 节日开始的年份
        /// </summary>
        int? LaunchYear{get; set; }
    }
}