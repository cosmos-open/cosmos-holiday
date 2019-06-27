using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday provider manager
    /// </summary>
    public class HolidayProviderManager : IHolidayProviderManager
    {
        // ReSharper disable once InconsistentNaming
        private readonly Dictionary<Type, IHolidayProvider> _providerCache;

        // ReSharper disable once InconsistentNaming
        private readonly object _lockObj = new object();

        /// <summary>
        /// Create a new instance of <see cref="HolidayProviderManager"/>
        /// </summary>
        public HolidayProviderManager()
        {
            _providerCache = new Dictionary<Type, IHolidayProvider>();
        }

        /// <summary>
        /// Get provider
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IHolidayProvider GetProvider(Type type)
        {
            if (type == null)
                return null;
            return _providerCache.TryGetValue(type, out var provider) ? provider : null;
        }

        /// <summary>
        /// Get provider
        /// </summary>
        /// <typeparam name="THolidayProvider"></typeparam>
        /// <returns></returns>
        public THolidayProvider GetProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new()
        {
            return (THolidayProvider) GetProvider(typeof(THolidayProvider));
        }

        /// <summary>
        /// Get required provider
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IHolidayProvider GetRequiredProvider(Type type)
        {
            var provider = GetProvider(type);
            if (provider == null)
                throw new ArgumentException("Provider has not been registered.");
            return provider;
        }

        /// <summary>
        /// Get required provider
        /// </summary>
        /// <typeparam name="THolidayProvider"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public THolidayProvider GetRequiredProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new()
        {
            var provider = GetProvider<THolidayProvider>();
            if (provider == null)
                throw new ArgumentException("Provider has not been registered.");
            return provider;
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="registerHolidayTypes"></param>
        /// <typeparam name="THolidayProvider"></typeparam>
        public void Register<THolidayProvider>(params HolidayType[] registerHolidayTypes)
            where THolidayProvider : class, IHolidayProvider, new()
        {
            Register(new THolidayProvider(), registerHolidayTypes);
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="registerHolidayTypes"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Register(IHolidayProvider provider, params HolidayType[] registerHolidayTypes)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));

            var type = provider.GetType();
            lock (_lockObj)
            {
                //step 1. register holiday
                if (registerHolidayTypes == null || registerHolidayTypes.Length == 0)
                    provider.RegisterAll();
                else
                    provider.Register(registerHolidayTypes);

                //step 2. register provider own.
                if (_providerCache.ContainsKey(type))
                    return;
                _providerCache.Add(type, provider);
            }
        }

        /// <summary>
        /// Keys
        /// </summary>
        public IEnumerable<Type> Keys => _providerCache.Keys;

        /// <summary>
        /// Count
        /// </summary>
        public int Count => _providerCache.Count;

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public bool Contains(Country country) => _providerCache.Values.Any(x => x.BelongsToCountry == country);

        /// <summary>
        /// Contains
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Contains(CountryCode code) => _providerCache.Values.Any(x => x.BelongsToCountry == code.ToCountry());

        /// <summary>
        /// Contains region
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public bool ContainsRegion(Country country) => _providerCache.Values.Any(x => x.Country == country);

        /// <summary>
        /// Contains region
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool ContainsRegion(CountryCode code) => _providerCache.Values.Any(x => x.Country == code.ToCountry());

    }
}