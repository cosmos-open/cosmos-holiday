using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday
{
    public interface IHolidayInfo
    {
        string Name { get; }

        int Length { get; }

        IEnumerable<HolidayInfo> GetAllDates();

        bool IsRestDay { get; }
    }
}