using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Globalization.Strategy.BuildInStrategies;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy
{
    internal static class DefaultSearchStrategiesGetter
    {
        private static readonly IEnumerable<ISearchStrategy> _preCustomDefineStrategy;
        private static readonly IEnumerable<ISearchStrategy> _postCustomDefineStrategy;
        private static List<ISearchStrategy> _defaultStratefyGroupCache { get; }

        static DefaultSearchStrategiesGetter()
        {
            _preCustomDefineStrategy = new List<ISearchStrategy>
            {
                new BasicNameSearchStrategy(),
                new BuildInI18NSearchStrategy()
            };

            _postCustomDefineStrategy = new List<ISearchStrategy> { };

            _defaultStratefyGroupCache = new List<ISearchStrategy>();
            _defaultStratefyGroupCache.AddRange(_preCustomDefineStrategy);
            _defaultStratefyGroupCache.AddRange(_postCustomDefineStrategy);
        }

        public static IReadOnlyCollection<ISearchStrategy> Get() => _defaultStratefyGroupCache;
    }
}