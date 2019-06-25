using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    /// <summary>
    /// Interface for business holiday definition
    /// </summary>
    public interface IBizHolidayDefinition
    {
        /// <summary>
        /// Country
        /// </summary>
        Country Country { get; }
    }
}