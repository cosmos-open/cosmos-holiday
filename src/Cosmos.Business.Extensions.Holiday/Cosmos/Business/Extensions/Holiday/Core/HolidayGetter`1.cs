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
        public HolidayGetter(IHolidayGetter anonymousGetter)
        {
            _provider = HolidayProviderManager.GetRequiredProvider<THolidayProvider>();
            _anonymousGetter = anonymousGetter ?? new HolidayGetter();
        }

        #region GetHolidays

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(int year)
        {
            return HolidayManager.GetHolidays(Country, year).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(int year, int month)
        {
            return HolidayManager.GetHolidays(Country, year, month).Select(HolidayFactory.Create);
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
            return HolidayManager.GetHolidays(Country, year, month, day).Select(HolidayFactory.Create);
        }

        /// <summary>
        /// Gets holiday
        /// </summary>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<IHolidayInfo> GetHolidays(string regionCode, int year)
        {
            regionCode = CountryHelper.FixRegionCode(Country, regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return HolidayManager.GetHolidays(Country, regionCode, year).Select(HolidayFactory.Create);
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
            regionCode = CountryHelper.FixRegionCode(Country, regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return HolidayManager.GetHolidays(Country, regionCode, year, month).Select(HolidayFactory.Create);
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
            regionCode = CountryHelper.FixRegionCode(Country, regionCode);
            if (!IncludeRegionCode(regionCode))
                return Enumerable.Empty<IHolidayInfo>();
            return HolidayManager.GetHolidays(Country, regionCode, year, month, day).Select(HolidayFactory.Create);
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

            return RegionIncluded.Any(x => x == regionCode);
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