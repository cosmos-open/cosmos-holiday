using System;
using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Weekend manager
    /// </summary>
    public static class WeekendManager
    {
        // ReSharper disable once InconsistentNaming
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        private static readonly Dictionary<CountryCode, IWeekendDictionary> _nonUniversalWeekends;

        static WeekendManager()
        {
            _nonUniversalWeekends = new Dictionary<CountryCode, IWeekendDictionary>();
        }

        #region GetWeekendDictionary

        /// <summary>
        /// Get weekend dictionary
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static IWeekendDictionary GetWeekendDictionary(CountryCode code)
        {
            return _nonUniversalWeekends.TryGetValue(code, out var dictionary)
                ? dictionary
                : WeekendDictionary.Universal;
        }

        /// <summary>
        /// Get weekend dictionary
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static IWeekendDictionary GetWeekendDictionary(Country country)
        {
            return GetWeekendDictionary(country.ToCode());
        }

        /// <summary>
        /// Get weekend dictionary
        /// </summary>
        /// <param name="countryInfo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IWeekendDictionary GetWeekendDictionary(CountryInfo countryInfo)
        {
            if (countryInfo == null)
                throw new ArgumentNullException(nameof(countryInfo));
            return GetWeekendDictionary(countryInfo.Country);
        }

        /// <summary>
        /// Get weekend dictionary
        /// </summary>
        /// <param name="weekendType"></param>
        /// <returns></returns>
        public static IWeekendDictionary GetWeekendDictionary(string weekendType)
        {
            var type = EnumsNET.Enums.GetMember<WeekendType>(weekendType, EnumFormat.EnumMemberValue, EnumFormat.Name, EnumFormat.DecimalValue);
            return (type?.Value ?? WeekendType.Universal).ToWeekendDictionary();
        }

        #endregion

        #region Register

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="code"></param>
        /// <param name="weekendDictionary"></param>
        internal static void Register(CountryCode code, IWeekendDictionary weekendDictionary)
        {
            if (weekendDictionary == null)
                return;

            if (_nonUniversalWeekends.ContainsKey(code))
                return;

            if (weekendDictionary.Type == WeekendType.Universal)
                return;

            _nonUniversalWeekends.Add(code, weekendDictionary);
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="definition"></param>
        internal static void Register(IBizWeekendDefinition definition)
        {
            if (definition == null)
                return;

            Register(
                definition.Country.ToCode(),
                definition.WeekendType.ToWeekendDictionary());
        }

        #endregion

    }
}