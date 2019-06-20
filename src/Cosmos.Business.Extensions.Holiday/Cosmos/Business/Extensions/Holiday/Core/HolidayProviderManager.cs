using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    internal static class HolidayProviderManager
    {
        private static readonly Dictionary<Type, IHolidayProvider> _providerCache;
        private static readonly object _lockObj = new object();

        static HolidayProviderManager()
        {
            _providerCache = new Dictionary<Type, IHolidayProvider>();
        }

        public static IHolidayProvider GetProvider(Type type)
        {
            if (type == null)
                return null;
            return _providerCache.TryGetValue(type, out var provider) ? provider : null;
        }

        public static THolidayProvider GetProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new()
        {
            return (THolidayProvider) GetProvider(typeof(THolidayProvider));
        }

        public static IHolidayProvider GetRequiredProvider(Type type)
        {
            var provider = GetProvider(type);
            if (provider == null)
                throw new ArgumentException("Provider has not been registered.");
            return provider;
        }

        public static THolidayProvider GetRequiredProvider<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new()
        {
            var provider = GetProvider<THolidayProvider>();
            if (provider == null)
                throw new ArgumentException("Provider has not been registered.");
            return provider;
        }

        public static void Register<THolidayProvider>()
            where THolidayProvider : class, IHolidayProvider, new()
        {
            Register(new THolidayProvider());
        }

        public static void Register(IHolidayProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException(nameof(provider));
            var type = provider.GetType();
            lock (_lockObj)
            {
                if (_providerCache.ContainsKey(type))
                    return;
                _providerCache.Add(type, provider);
            }
        }

        public static IEnumerable<Type> Keys => _providerCache.Keys;

        public static int Count => _providerCache.Count;

        public static bool Contains(Country country) => _providerCache.Values.Any(x => x.BelongsToCountry == country);

        public static bool Contains(CountryCode code) => _providerCache.Values.Any(x => x.BelongsToCountry == code.ToCountry());
    }
}