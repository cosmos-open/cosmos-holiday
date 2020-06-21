using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    internal static class EmbeddedResourceGetter
    {
        public static EmbeddedResourceTemplate DateTemplate
            => EmbeddedResourceReader.ReadDateResource().ToTemplate();

        public static EmbeddedResourceTemplate EasterTemplate
            => EmbeddedResourceReader.ReadEasterResource().ToTemplate();

        public static EmbeddedResourceTemplate JewishTemplate
            => EmbeddedResourceReader.ReadJewishResource().ToTemplate();

        public static EmbeddedResourceTemplate MuslimTemplate
            => EmbeddedResourceReader.ReadMuslimResource().ToTemplate();

        public static EmbeddedResourceTemplate NameTemplate
            => EmbeddedResourceReader.ReadNameResource().ToTemplate();

        public static EmbeddedResourceTemplate OrthodoxTemplate
            => EmbeddedResourceReader.ReadOrthodoxResource().ToTemplate();

        public static EmbeddedResourceTemplate ChineseTemplate
            => EmbeddedResourceReader.ReadChineseResource().ToTemplate();

        public static IEnumerable<EmbeddedResourceTemplate> All
        {
            get
            {
                yield return DateTemplate;
                yield return NameTemplate;
                yield return EasterTemplate;
                yield return OrthodoxTemplate;
                yield return ChineseTemplate;
                yield return JewishTemplate;
                yield return MuslimTemplate;
            }
        }

        private static EmbeddedResourceTemplate ToTemplate(this string rawText)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<EmbeddedResourceTemplate>(rawText);
        }
    }
}