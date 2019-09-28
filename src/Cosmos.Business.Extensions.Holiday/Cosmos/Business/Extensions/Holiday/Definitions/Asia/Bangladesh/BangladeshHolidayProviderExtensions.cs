using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Bangladesh holiday provider extensions
    /// </summary>
    public static class BangladeshHolidayProviderExtensions
    {
        /// <summary>
        /// Use Bangladesh holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseBangladesh<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<BangladeshHolidayProvider>(holidayTypes);
        }
    }
}