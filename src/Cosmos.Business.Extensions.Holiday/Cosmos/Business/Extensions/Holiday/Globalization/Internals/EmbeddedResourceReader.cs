using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Cosmos.Business.Extensions.Holiday.EmbeddedResTests")]

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    /// <summary>
    /// Globalization embedded resource reader
    /// </summary>
    internal static class EmbeddedResourceReader
    {
        /// <summary>
        /// Read date resource
        /// </summary>
        /// <returns></returns>
        public static string ReadDateResource() => GetResource("i18n.date.json").Return();

        /// <summary>
        /// Read easter resource
        /// </summary>
        /// <returns></returns>
        public static string ReadEasterResource() => GetResource("i18n.easter.json").Return();

        /// <summary>
        /// Read jewish resource
        /// </summary>
        /// <returns></returns>
        public static string ReadJewishResource() => GetResource("i18n.jewish.json").Return();

        /// <summary>
        /// Read muslim resource
        /// </summary>
        /// <returns></returns>
        public static string ReadMuslimResource() => GetResource("i18n.muslim.json").Return();

        /// <summary>
        /// Read name resource
        /// </summary>
        /// <returns></returns>
        public static string ReadNameResource() => GetResource("i18n.name.json").Return();

        /// <summary>
        /// Read orthodox resource
        /// </summary>
        /// <returns></returns>
        public static string ReadOrthodoxResource() => GetResource("i18n.orthodox.json").Return();

        /// <summary>
        /// Read Chinese resource
        /// </summary>
        /// <returns></returns>
        public static string ReadChineseResource() => GetResource("i18n.chinese.json").Return();

        private static string Return(this Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private static Stream GetResource(string resourceName)
        {
            if (string.IsNullOrWhiteSpace(resourceName))
                throw new ArgumentNullException(nameof(resourceName));

            var @namespace = typeof(GlobalizationManager).Namespace;
            return Assembly.GetExecutingAssembly().GetManifestResourceStream($"{@namespace}.{resourceName}");
        }
    }
}