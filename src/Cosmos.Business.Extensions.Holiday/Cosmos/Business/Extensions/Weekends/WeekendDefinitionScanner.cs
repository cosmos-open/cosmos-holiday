using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Weekends.SpecialDefinitions;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Weekend deginition scanner
    /// </summary>
    public class WeekendDefinitionScanner
    {
        /// <summary>
        /// Create a new instance of <see cref="WeekendDefinitionScanner"/>
        /// </summary>
        /// <param name="includeExtendDefinitions"></param>
        /// <param name="unlinkedAssembliesPattern"></param>
        public WeekendDefinitionScanner(bool includeExtendDefinitions = false, string unlinkedAssembliesPattern = "")
        {
            IncludeExtendDefinitions = includeExtendDefinitions;
            UnlinkedAssembliesPattern = unlinkedAssembliesPattern;
        }

        /// <summary>
        /// Include extend definitions
        /// </summary>
        public bool IncludeExtendDefinitions { get; }

        /// <summary>
        /// Unlinked assemblies pattern
        /// </summary>
        public string UnlinkedAssembliesPattern { get; }

        /// <summary>
        /// Do Scan
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IBizWeekendDefinition> Scan()
        {
            foreach (var definition in BuildInDefinitions)
                yield return definition;

            if (!IncludeExtendDefinitions)
                yield break;

            foreach (var definition in ScanExtendDefinitions())
                yield return definition;
        }
        
        #region extend definition scanner

        private IEnumerable<IBizWeekendDefinition> ScanExtendDefinitions()
        {
            using (var scanner = new InnerScanner(UnlinkedAssembliesPattern))
            {
                return scanner.ScanAndReturnInstances();
            }
        }

        private class InnerScanner : InstanceScanner<IBizWeekendDefinition>
        {
            private readonly string _unlinkedAssembliesPattern;

            public InnerScanner(string unlinkedAssembliesPattern)
            {
                _unlinkedAssembliesPattern = unlinkedAssembliesPattern;
            }

            // ReSharper disable once InconsistentNaming
            private const string SKIP_ASSEMBLIES =
                "^System|^Mscorlib|^Netstandard|^Microsoft|^Autofac|^AutoMapper|^EntityFramework|^Newtonsoft|^Castle|^NLog|^Pomelo|^AspectCore|^Xunit|^Nito|^Npgsql|^Exceptionless|^MySqlConnector|^Anonymously Hosted";

            protected override string GetSkipAssembliesNamespaces() => SKIP_ASSEMBLIES;

            protected override Assembly[] GetAssemblies()
            {
                if (string.IsNullOrWhiteSpace(_unlinkedAssembliesPattern))
                    return base.GetAssemblies();
                return base.GetAssemblies().Concat(GetAllUnlinkedAssemblies(_unlinkedAssembliesPattern)).Distinct().ToArray();
            }

            private static IEnumerable<Assembly> GetAllUnlinkedAssemblies(string extendAssembliesPattern)
            {
                var directoryRoot = new DirectoryInfo(Directory.GetCurrentDirectory());
                var files = directoryRoot.GetFiles(extendAssembliesPattern, SearchOption.AllDirectories);
                foreach (var file in files)
                    yield return Assembly.LoadFrom(file.FullName);
            }

            protected override Func<Type, bool> TypeFilter() =>
                t => t.IsPublic && t.IsClass && !t.IsAbstract &&
                     BaseType.IsAssignableFrom(t) &&
                     t.IsNotDefined<WeekendDefinitionIgnoreScanningAttribute>();
        }

        #endregion

        #region build in definitions

        private static readonly IEnumerable<IBizWeekendDefinition> BuildInDefinitions = new List<IBizWeekendDefinition>
        {
            new Afghanistan(),
            new Algeria(),
            new Bahrain(),
            new Bangladesh(),
            new Brunei(),
            new Djibouti(),
            new Egypt(),
            new EquatorialGuinea(),
            new HongKong(),
            new Iran(),
            new Iraq(),
            new Israel(),
            new Jordan(),
            new Kuwait(),
            new Libya(),
            new Maldives(),
            new Mexico(),
            new Nepal(),
            new Oman(),
            new Palestine(),
            new Philippines(),
            new Qatar(),
            new SaudiArabia(),
            new Somalia(),
            new Sudan(),
            new Syrian(),
            new Uganda(),
            new UnitedArabEmirates(),
            new Yemen()
        };

        #endregion

    }
}