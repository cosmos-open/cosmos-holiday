using Cosmos.Business.Extensions.Holiday.Globalization;

namespace Cosmos.Abstractions
{
    /// <summary>
    /// Interface for business holiday globalization manager
    /// </summary>
    public interface IBizHolidayGlobalizationManager
    {
        /// <summary>
        /// Get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        string GetText(string key, string lang);

        /// <summary>
        /// Get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetText(string key, string lang, ResourceType type);

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool TryGetText(string key, string lang, out string text);

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool TryGetText(string key, string lang, ResourceType type, out string text);
    }
}