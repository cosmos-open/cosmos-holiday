using Cosmos.Business.Extensions.Holiday.Configuration;
using Cosmos.Business.Extensions.Holiday.Definitions.Asia.China;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// China holiday provider extensions
    /// </summary>
    public static class ChinaHolidayProviderExtensions
    {
        /// <summary>
        /// Use China holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseChina<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<ChinaHolidayProvider>(holidayTypes);
        }
    }
}