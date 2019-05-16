using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Configuration;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class BaseHolidayDictionaryProvider : IHolidayDictionaryProvider
    {
        protected BaseHolidayDictionaryProvider(HolidayConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            CountryCode = EnumsNET.Enums.GetMember<CountryCode>(configuration.CountryCode, EnumFormat.EnumMemberValue).Value;
            HolidayDescriptors = configuration.Holidays;
        }

        public CountryCode CountryCode { get; private set; }

        public List<HolidayDescriptor> HolidayDescriptors { get; private set; }
    }
}