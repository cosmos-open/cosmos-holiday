using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class BaseHolidayDictionary : IHolidayDictionary
    {
        protected BaseHolidayDictionary(CountryCode code)
        {
            CountryCode = code;
            BelongsToCountryCode = code;
        }
        
        protected BaseHolidayDictionary(CountryCode code, CountryCode belongsToCountryCode)
        {
            CountryCode = code;
            BelongsToCountryCode = belongsToCountryCode;
        }

        public CountryCode CountryCode { get; }
        public CountryCode BelongsToCountryCode { get; }
    }
}