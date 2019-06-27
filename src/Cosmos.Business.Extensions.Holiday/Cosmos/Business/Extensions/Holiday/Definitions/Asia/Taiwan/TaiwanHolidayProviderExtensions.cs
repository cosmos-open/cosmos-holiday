using Cosmos.Business.Extensions.Holiday.Configuration;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// China Taiwan holiday provider extensions
    /// </summary>
    public static class ChinaTwHolidayProviderExtensions
    {
        /// <summary>
        /// Use China Taiwan holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseTaiwan<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<TaiwanHolidayProvider>(holidayTypes);
        }
    }
}