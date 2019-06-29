using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// United Kingdom holiday provider extensions
    /// </summary>
    public static class UnitedKingdomHolidayProviderExtensions
    {

        /// <summary>
        /// Use United Kingdom holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseUnitedKingdom<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<UnitedKingdomHolidayProvider>(holidayTypes);
        }
    }
}