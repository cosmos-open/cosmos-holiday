using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Zimbabwe holiday provider extensions
    /// </summary>
    public static class ZimbabweHolidayProviderExtensions
    {
        /// <summary>
        /// Use Zimbabwe holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseZimbabwe<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<ZimbabweHolidayProvider>(holidayTypes);
        }
    }
}