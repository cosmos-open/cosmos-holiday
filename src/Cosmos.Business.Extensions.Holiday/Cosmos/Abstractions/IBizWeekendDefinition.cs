using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    public interface IBizWeekendDefinition
    {
        CountryCode CountryCode { get; }
        WeekendType WeekendType { get; }
    }
}