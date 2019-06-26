using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday Manager
    /// </summary>
    public partial class HolidayManager
    {
        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IWeekendDictionary GetWeekendDictionary(CountryCode code) => WeekendManager.GetWeekendDictionary(code);

        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by weekend type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IWeekendDictionary GetWeekendDictionary(string type) => WeekendManager.GetWeekendDictionary(type);
    }
}