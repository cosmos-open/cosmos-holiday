using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public interface IHolidayDictionary
    {
        CountryCode CountryCode { get; }
        CountryCode BelongsToCountryCode { get; }
    }
}