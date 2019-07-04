using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Kazakhstan holiday provider extensions
    /// </summary>
    public static class KazakhstanHolidayProviderExtensions
    {
        /// <summary>
        /// Use Kazakhstan holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseKazakhstan<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<KazakhstanHolidayProvider>(holidayTypes);
        }
    }
}