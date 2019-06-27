using Cosmos.Business.Extensions.Holiday.Configuration;
using Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// China Macao holiday provider extensions
    /// </summary>
    public static class ChinaMoHolidayProviderExtensions
    {
        /// <summary>
        /// Use China Macao holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseMacao<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<MacaoHolidayProvider>(holidayTypes);
        }
    }
}