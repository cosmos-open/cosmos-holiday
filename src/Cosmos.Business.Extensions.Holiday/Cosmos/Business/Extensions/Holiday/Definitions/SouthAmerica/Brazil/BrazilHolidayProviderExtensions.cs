using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Brazil holiday provider extensions
    /// </summary>
    public static class BrazilHolidayProviderExtensions
    {
        /// <summary>
        /// Use Brazil holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseBrazil<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<BrazilHolidayProvider>(holidayTypes);
        }
    }
}