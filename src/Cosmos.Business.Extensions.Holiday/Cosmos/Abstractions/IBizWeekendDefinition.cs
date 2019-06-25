using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Abstractions
{
    /// <summary>
    /// Interface for business weekend definition
    /// </summary>
    public interface IBizWeekendDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        Country Country { get; }
        
        /// <summary>
        /// Type of weekend
        /// </summary>
        WeekendType WeekendType { get; }
    }
}