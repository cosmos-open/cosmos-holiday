using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Configuration;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public interface IHolidayDictionaryProvider
    {
        CountryCode CountryCode { get; }

        List<HolidayDescriptor> HolidayDescriptors { get; }
    }
}