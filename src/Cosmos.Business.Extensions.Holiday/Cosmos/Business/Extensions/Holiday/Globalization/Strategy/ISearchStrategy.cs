using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy
{
    /// <summary>
    /// Interface for holiday resource search strategy
    /// </summary>
    public interface ISearchStrategy
    {
        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="holidayDefinition"></param>
        /// <param name="languageTag"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool TryGetText(IHolidayFunc holidayDefinition, string languageTag, out string text);
    }
}