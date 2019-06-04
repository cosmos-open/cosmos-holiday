using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    public interface IBizRegionHolidayDefinition
    {
        Country BelongsToCountry { get; }
    }
}