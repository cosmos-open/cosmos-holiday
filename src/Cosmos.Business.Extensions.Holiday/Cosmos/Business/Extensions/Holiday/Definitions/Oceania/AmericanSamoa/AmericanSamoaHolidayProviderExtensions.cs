using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// American Samoa Holiday Provider Extensions
    /// </summary>
    public static class AmericanSamoaHolidayProviderExtensions
    {
        /// <summary>
        /// Use American Samoa holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseAmericanSamoa<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<AmericanSamoaHolidayProvider>(holidayTypes);
        }
    }
}