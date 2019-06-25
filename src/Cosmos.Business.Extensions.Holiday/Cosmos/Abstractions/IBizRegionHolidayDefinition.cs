using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    /// <summary>
    /// Interface for business region holiday definition
    /// </summary>
    public interface IBizRegionHolidayDefinition
    {
        /// <summary>
        /// Belongs to Country
        /// </summary>
        Country BelongsToCountry { get; }
    }
}