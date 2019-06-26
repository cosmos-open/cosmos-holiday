using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday Manager
    /// </summary>
    public partial class HolidayManager
    {

        #region Add

        /// <summary>
        /// Add <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="func"></param>
        public void Add(IVariableHolidayFunc func)
        {
            _variableDailyNodeTree.ExposeRoot.Add(func);
        }

        /// <summary>
        /// Add a collection of <see cref="IVariableHolidayFunc"/> into <see cref="HolidayManager"/>.
        /// </summary>
        /// <param name="funcColl"></param>
        public void AdRange(IEnumerable<IVariableHolidayFunc> funcColl)
        {
            _variableDailyNodeTree.ExposeRoot.AddRange(funcColl);
        }

        #endregion

        #region Gets

        /// <summary>
        /// Get all variable holiday func
        /// </summary>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get()
        {
            return _variableDailyNodeTree.ExposeRoot.Get();
        }

        /// <summary>
        /// Get all variable holiday func by special year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(int year)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(year);
        }

        /// <summary>
        /// Get all variable holiday func by special country code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(CountryCode code)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(code);
        }

        /// <summary>
        /// Get all variable holiday func by special country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(Country country)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(country);
        }

        /// <summary>
        /// Get all variable holiday func by special country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(CountryCode code, string regionCode)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(code, regionCode);
        }

        /// <summary>
        /// Get all variable holiday func by special country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(Country country, string regionCode)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(country, regionCode);
        }

        /// <summary>
        /// Get all variable holiday func by special year and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(CountryCode code, int year)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(code, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(Country country, int year)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(country, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year, country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(CountryCode code, string regionCode, int year)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(code, regionCode, year);
        }

        /// <summary>
        /// Get all variable holiday func by special year, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        IEnumerable<IVariableHolidayFunc> IVariableHolidayManager.Get(Country country, string regionCode, int year)
        {
            return _variableDailyNodeTree.ExposeRoot.Get(country, regionCode, year);
        }

        #endregion

        #region Gets DailyAnswer

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(int year)
        {
            return _variableDailyNodeTree.Get(year);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month)
        {
            return _variableDailyNodeTree.Get(year, month);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(int year, int month, int day)
        {
            return _variableDailyNodeTree.Get(year, month, day);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year)
        {
            return _variableDailyNodeTree.Get(code, year);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), year);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year)
        {
            return _variableDailyNodeTree.Get(code, regionCode, year);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), regionCode, year);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month)
        {
            return _variableDailyNodeTree.Get(code, year, month);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), year, month);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month)
        {
            return _variableDailyNodeTree.Get(code, regionCode, year, month);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), regionCode, year, month);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, int year, int month, int day)
        {
            return _variableDailyNodeTree.Get(code, year, month, day);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, int year, int month, int day)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), year, month, day);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(CountryCode code, string regionCode, int year, int month, int day)
        {
            return _variableDailyNodeTree.Get(code, regionCode, year, month, day);
        }

        /// <inheritdoc />
        public IEnumerable<DailyAnswer> GetVariableHolidays(Country country, string regionCode, int year, int month, int day)
        {
            return _variableDailyNodeTree.Get(country.ToCode(), regionCode, year, month, day);
        }

        #endregion

    }
}