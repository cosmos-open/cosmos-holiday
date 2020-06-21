using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Core Holiday Func
    /// </summary>
    public interface IHolidayFunc
    {

        #region Holiday in Country and Region

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

        /// <summary>
        /// Match region code...
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        bool MatchRegion(string regionCode);

        #endregion

        #region Holiday Type

        /// <summary>
        /// Type of Holiday
        /// </summary>
        HolidayType HolidayType { get; }

        #endregion

        #region Holiday Name

        /// <summary>
        /// Local Name of Holiday
        /// </summary>
        string Name { get; }

        #endregion

        #region Holiday I18n Code

        /// <summary>
        /// I18N Code
        /// </summary>
        string I18NIdentityCode { get; }

        /// <summary>
        /// Globalization Key
        /// </summary>
        string GlobalizationKey { get; }

        #endregion

    }
}