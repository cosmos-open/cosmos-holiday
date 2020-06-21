using System;
using System.IO;
using System.Reflection;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Humanizer;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    internal static class BuildInResourceReader
    {
        public static string Get(Country country, string languageTag) => GetResource(country, languageTag).Return();
        
        private static string Return(this Stream stream)
        {
            if (stream == null)
            {
                return string.Empty;
            }

            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static Stream GetResource(Country country, string languageTag)
        {
            if (string.IsNullOrWhiteSpace(languageTag))
                throw new ArgumentNullException(nameof(languageTag));

            var @namespace = typeof(BaseDefinitionRegister).Namespace;
            var continent = CountryManager.GetCountryInfo(country).Continent.Humanize();
            var countryName = country.Humanize();
            var resourceName = $"i18n_holiday_{countryName.ToLower()}.{languageTag.ToLower()}.json";
            return Assembly.GetExecutingAssembly()
                .GetManifestResourceStream($"{@namespace}.{continent}.{countryName}.{resourceName}");
        }
    }
}