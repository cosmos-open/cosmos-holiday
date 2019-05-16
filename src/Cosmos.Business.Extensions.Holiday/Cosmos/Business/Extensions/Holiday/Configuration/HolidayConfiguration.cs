using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Configuration
{
    public class HolidayConfiguration
    {
        public string CountryCode { get; set; }

        public List<HolidayDescriptor> Holidays { get; set; }
    }
}