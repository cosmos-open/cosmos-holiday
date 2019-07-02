using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday getter
    /// </summary>
    /// <typeparam name="THolidayProvider"></typeparam>
    public class HolidayGetter<THolidayProvider> : IHolidayGetter<THolidayProvider>
        where THolidayProvider : class, IHolidayProvider, new()
    {
        private readonly IHolidayManager _manager;
        private readonly THolidayProvider _provider;
        private readonly IHolidayGetter _anonymousGetter;

        /// <summary>
        /// Country or region
        /// </summary>
        private Country Country => _provider.Country;

        private IEnumerable<string> RegionIncluded => _provider.IncludeRegions();

        /// <summary>
        /// Holiday getter
        /// </summary>
        /// <param name="anonymousGetter"></param>
        /// <param name="holidayManager"></param>
        /// <param name="holidayProviderManager"></param>
        public HolidayGetter(IHolidayGetter anonymousGetter, IHolidayManager holidayManager, IHolidayProviderManager holidayProviderManager)
        {
            if (holidayProviderManager == null)
                throw new ArgumentNullException(nameof(holidayProviderManager));

            _manager = holidayManager ?? throw new ArgumentNullException(nameof(holidayManager));
            _provider = holidayProviderManager.GetRequiredProvider<THolidayProvider>();
            _anonymousGetter = anonymousGetter ?? new HolidayGetter(holidayManager);
        }

        #region GetHolidays

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(int year)
        {
            return _manager.GetHolidays(Country, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(int year, int month)
        {
            return _manager.GetHolidays(Country, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(int year, int month, int day)
        {
            return _manager.GetHolidays(Country, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year)
        {
            regionCode = FixRegionCode(regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return _manager.GetHolidays(Country, regionCode, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year, int month)
        {
            regionCode = FixRegionCode(regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return _manager.GetHolidays(Country, regionCode, year, month).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year, int month, int day)
        {
            regionCode = FixRegionCode(regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return _manager.GetHolidays(Country, regionCode, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        private bool IncludeRegionCode(string regionCode)
        {
            //If there is no region code in provider, then allow developer to query holiday directly. 
            if (!RegionIncluded.Any())
                return true;

            if (RegionIncluded.Any(x => x == regionCode))
                return true;

            return _provider.DoesIncludeRegion(regionCode);
        }

        /// <summary>
        /// Fix region code after check exist.
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        private string FixRegionCode(string regionCode)
        {
            regionCode = CountryHelper.FixRegionCode(Country, regionCode);
            return _provider.FixRegionCode(regionCode);
        }

        #endregion

        #region AnonymousGetter

        /// <summary>
        /// Anonymous holiday getter
        /// </summary>
        public IHolidayGetter Anonymous => _anonymousGetter;

        #endregion

    }
}