using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    public interface IBizRegionHolidayDefinition
    {
        CountryCode BelongsToCountryCode { get; }
    }
}