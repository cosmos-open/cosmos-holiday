using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// BurkinaFaso holiday provider extensions
    /// </summary>
    public static class BurkinaFasoHolidayProviderExtensions
    {
        /// <summary>
        /// Use BurkinaFaso holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseBurkinaFaso<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<BurkinaFasoHolidayProvider>(holidayTypes);
        }
    }
}