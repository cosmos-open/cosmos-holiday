using System;
using System.Linq;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday getter
    /// </summary>
    public class HolidayGetter : IHolidayGetter
    {
        private readonly IHolidayManager _manager;

        /// <summary>
        /// Holiday getter
        /// </summary>
        /// <param name="holidayManager"></param>
        public HolidayGetter(IHolidayManager holidayManager)
        {
            _manager = holidayManager ?? throw new ArgumentNullException(nameof(holidayManager));
        }

        #region GetHolidays

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year)
        {
            return _manager.GetHolidays(country, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year)
        {
            return _manager.GetHolidays(code, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month)
        {
            return _manager.GetHolidays(country, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month)
        {
            return _manager.GetHolidays(code, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month, int day)
        {
            return _manager.GetHolidays(country, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month, int day)
        {
            return _manager.GetHolidays(code, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return _manager.GetHolidays(country, regionCode, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return _manager.GetHolidays(code, regionCode, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return _manager.GetHolidays(country, regionCode, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return _manager.GetHolidays(code, regionCode, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month, int day)
        {
            regionCode = CountryHelper.FixRegionCode(country, regionCode);
            return _manager.GetHolidays(country, regionCode, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            regionCode = CountryHelper.FixRegionCode(code, regionCode);
            return _manager.GetHolidays(code, regionCode, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, HolidayType type)
        {
            return GetHolidays(country, year).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, HolidayType type)
        {
            return GetHolidays(code, year).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month, HolidayType type)
        {
            return GetHolidays(country, year, month).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month, HolidayType type)
        {
            return GetHolidays(code, year, month).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, int year, int month, int day, HolidayType type)
        {
            return GetHolidays(country, year, month, day).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, int year, int month, int day, HolidayType type)
        {
            return GetHolidays(code, year, month, day).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, HolidayType type)
        {
            return GetHolidays(country, regionCode, year).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, HolidayType type)
        {
            return GetHolidays(code, regionCode, year).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month, HolidayType type)
        {
            return GetHolidays(country, regionCode, year, month).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month, HolidayType type)
        {
            return GetHolidays(code, regionCode, year, month).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(Country country, string regionCode, int year, int month, int day, HolidayType type)
        {
            return GetHolidays(country, regionCode, year, month, day).Filter(type);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<IHolidayInfo> GetHolidays(CountryCode code, string regionCode, int year, int month, int day, HolidayType type)
        {
            return GetHolidays(code, regionCode, year, month, day).Filter(type);
        }

        #endregion

    }
}