using System;
using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface for holiday provider manager
    /// </summary>
    public interface IHolidayProviderManager
    {
        /// <summary>
        /// Get holiday provider
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IHolidayProvider GetProvider(Type type);

        /// <summary>
        /// Get holiday provider
        /// </summary>
        /// <typeparam name="THolidayProvider"></typeparam>
        /// <returns></returns>
        THolidayProvider GetProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new();

        /// <summary>
        /// Get holiday provider
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IHolidayProvider GetRequiredProvider(Type type);

        /// <summary>
        /// Get holiday provider
        /// </summary>
        /// <typeparam name="THolidayProvider"></typeparam>
        /// <returns></returns>
        THolidayProvider GetRequiredProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new();

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="registerHolidayTypes"></param>
        /// <typeparam name="THolidayProvider"></typeparam>
        void Register<THolidayProvider>(params HolidayType[] registerHolidayTypes)
            where THolidayProvider : class, IHolidayProvider, new();

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="registerHolidayTypes"></param>
        void Register(IHolidayProvider provider, params HolidayType[] registerHolidayTypes);

        /// <summary>
        /// Keys
        /// </summary>
        IEnumerable<Type> Keys { get; }

        /// <summary>
        /// Count
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        bool Contains(Country country);

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool Contains(CountryCode code);

        /// <summary>
        /// Contains region
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        bool ContainsRegion(Country country);

        /// <summary>
        /// Contains region
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        bool ContainsRegion(CountryCode code);
    }
}