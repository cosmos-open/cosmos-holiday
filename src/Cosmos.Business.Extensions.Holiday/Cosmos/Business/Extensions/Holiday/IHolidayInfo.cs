using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Interface of holiday info
    /// </summary>
    public interface IHolidayInfo
    {
        /// <summary>
        /// Holiday name<br />
        /// 节假日名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Holiday Type<br />
        /// 假期类型
        /// </summary>
        HolidayType Type { get; }

        /// <summary>
        /// Country code
        /// </summary>
        CountryCode CountryCode { get; }

        /// <summary>
        /// Length
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Since...
        /// </summary>
        int? LaunchYear { get; }

        /// <summary>
        /// End...
        /// </summary>
        int? EndYear { get; }

        /// <summary>
        /// I18N Identity Code
        /// </summary>
        string I18NIdentityCode { get; }

        /// <summary>
        /// Match date by year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        bool Match(int year);

        /// <summary>
        /// Match date by year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        bool Match(int year, int month);

        /// <summary>
        /// Match date by year, month and day
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        bool Match(int year, int month, int day);

        /// <summary>
        /// Match country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        bool Match(Country country);

        /// <summary>
        /// Match country
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool Match(CountryCode code);

        /// <summary>
        /// Match region
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        bool Match(string regionCode);

        /// <summary>
        /// Match country and region
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        bool Match(Country country, string regionCode);

        /// <summary>
        /// Match country and region
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        bool Match(CountryCode code, string regionCode);

        /// <summary>
        /// Match regions
        /// </summary>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        bool Match(IEnumerable<string> regionCodeList);

        /// <summary>
        /// Match country and regions
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        bool Match(Country country, IEnumerable<string> regionCodeList);

        /// <summary>
        /// Match country and regions
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        bool Match(CountryCode code, IEnumerable<string> regionCodeList);
    }
}