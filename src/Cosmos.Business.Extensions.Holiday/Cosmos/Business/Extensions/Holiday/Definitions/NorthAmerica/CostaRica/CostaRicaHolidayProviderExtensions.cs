using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// CostaRica Holiday Provider Extensions
    /// </summary>
    public static class CostaRicaHolidayProviderExtensions
    {
        /// <summary>
        /// Use CostaRica holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseCostaRica<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<CostaRicaHolidayProvider>(holidayTypes);
        }
    }
}