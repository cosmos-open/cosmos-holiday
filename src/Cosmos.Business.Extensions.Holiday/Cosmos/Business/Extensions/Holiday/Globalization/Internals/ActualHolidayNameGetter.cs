using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Globalization.Strategy;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    /// <summary>
    /// Actual Holiday Name Getter
    /// </summary>
    public class ActualHolidayNameGetter
    {
        /// <summary>
        /// Actual holiday name cache<br />
        /// Key of value = i18n_code + globalization_code + lang
        /// </summary>
        private readonly Dictionary<Country, Dictionary<int, string>> _actualNameCache;

        /// <summary>
        /// Default search strategy group
        /// </summary>
        private readonly IEnumerable<ISearchStrategy> _defaultStrategyGroup;

        /// <summary>
        /// Create a new instance of <see cref="ActualHolidayNameGetter"/>.
        /// </summary>
        public ActualHolidayNameGetter() : this(null) { }

        /// <summary>
        /// Create a new instance of <see cref="ActualHolidayNameGetter"/>.
        /// </summary>
        /// <param name="defaultStrategyGroup"></param>
        public ActualHolidayNameGetter(IEnumerable<ISearchStrategy> defaultStrategyGroup)
        {
            _actualNameCache = new Dictionary<Country, Dictionary<int, string>>();
            _defaultStrategyGroup = defaultStrategyGroup ?? DefaultSearchStrategiesGetter.Get();
        }

        /// <summary>
        /// Gets default strategy group
        /// </summary>
        public IEnumerable<ISearchStrategy> Default => _defaultStrategyGroup;
    }
}