using Cosmos.Business.Extensions.Holiday.Configuration;

/*
 * Hong Kong, a part of China
 * 香港，中华人民共和国的一部分
 */

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// China HongKong holiday provider extensions
    /// </summary>
    public static class ChinaHkHolidayProviderExtensions
    {
        /// <summary>
        /// Use China HongKong holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseHongKong<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<HongKongHolidayProvider>(holidayTypes);
        }
    }
}