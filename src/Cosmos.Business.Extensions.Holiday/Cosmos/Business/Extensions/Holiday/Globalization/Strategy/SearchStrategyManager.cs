using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Globalization.Internals;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy
{
    /// <summary>
    /// Search Strategy Manager
    /// </summary>
    public class SearchStrategyManager
    {
        private readonly List<ISearchStrategy> _searchStrategies;
        private readonly ActualHolidayNameGetter _nameGetter;

        /// <summary>
        /// Create a new instance of <see cref="SearchStrategyManager"/>.
        /// </summary>
        public SearchStrategyManager(ActualHolidayNameGetter getter)
        {
            _searchStrategies = new List<ISearchStrategy>();
            _nameGetter = getter ?? throw new ArgumentNullException(nameof(getter));
        }

        /// <summary>
        /// Get default strategies
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<ISearchStrategy> GetDefaultStrategies() => _nameGetter.Default.ToList();

        /// <summary>
        /// Get strategies
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<ISearchStrategy> GetStrategies() => _searchStrategies.AsReadOnly();
    }
}