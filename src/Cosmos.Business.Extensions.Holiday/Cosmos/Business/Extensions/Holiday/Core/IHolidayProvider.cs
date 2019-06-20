using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public interface IHolidayProvider
    {
        Country Country { get; }

        Country BelongsToCountry { get; }

        IEnumerable<string> IncludeRegions();
    }
}