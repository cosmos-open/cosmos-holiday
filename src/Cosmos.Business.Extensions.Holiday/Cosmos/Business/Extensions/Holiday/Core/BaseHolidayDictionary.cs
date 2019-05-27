using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class BaseHolidayDictionary : IHolidayDictionary
    {
        protected BaseHolidayDictionary(CountryCode code)
        {
            CountryCode = code;
        }

        public CountryCode CountryCode { get; }
    }
}