using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    public interface IBizWeekendDefinition
    {
        Country Country { get; }
        WeekendType WeekendType { get; }
    }
}