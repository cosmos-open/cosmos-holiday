using System;
using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    internal static class BuildInResourceGetter
    {
        private static readonly Dictionary<(Country, string), BuildInResourceTemplate> _templateCache;
        private static readonly object _templateLockObj = new object();

        static BuildInResourceGetter()
        {
            _templateCache = new Dictionary<(Country, string), BuildInResourceTemplate>();
        }

        public static BuildInResourceTemplate Template(Country country, string languageTag)
        {
            if (string.IsNullOrWhiteSpace(languageTag))
                throw new ArgumentNullException(nameof(country));

            var key = (country, languageTag);

            // ReSharper disable once InconsistentlySynchronizedField
            if (_templateCache.TryGetValue(key, out var value))
                return value;

            value = BuildInResourceReader.Get(country, languageTag).ToTemplate();

            lock (_templateLockObj)
            {
                return _templateCache[key] = value;
            }
        }

        private static BuildInResourceTemplate ToTemplate(this string rawText)
        {
            if (string.IsNullOrWhiteSpace(rawText))
            {
                return default;
            }

            try
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<BuildInResourceTemplate>(rawText);
            }
            catch
            {
                return default;
            }
        }
    }
}