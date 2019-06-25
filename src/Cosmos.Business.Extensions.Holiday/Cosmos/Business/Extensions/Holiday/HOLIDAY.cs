using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Static holiday helper
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class HOLIDAY
    {
        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, int year)
        {
            return HolidayManager.GetHolidays(country, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year)
        {
            return HolidayManager.GetHolidays(code, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month)
        {
            return HolidayManager.GetHolidays(country, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month)
        {
            return HolidayManager.GetHolidays(code, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month, int day)
        {
            return HolidayManager.GetHolidays(country, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month, int day)
        {
            return HolidayManager.GetHolidays(code, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return HolidayManager.GetHolidays(country, regionCode, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return HolidayManager.GetHolidays(code, regionCode, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return HolidayManager.GetHolidays(country, regionCode, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return HolidayManager.GetHolidays(code, regionCode, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month, int day)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return HolidayManager.GetHolidays(country, regionCode, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Get holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return HolidayManager.GetHolidays(code, regionCode, year, month, day).Select(HolidayFactory.Create);
        }
    }
}