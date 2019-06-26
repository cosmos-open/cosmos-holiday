using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of Weekend Holiday Manager
    /// </summary>
    public interface IWeekendHolidayManager
    {
        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        IWeekendDictionary GetWeekendDictionary(CountryCode code);

        /// <summary>
        /// Gets <see cref="WeekendDictionary"/> by weekend type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IWeekendDictionary GetWeekendDictionary(string type);
    }
}