using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// SouthAfrica holiday provider extensions
    /// </summary>
    public static class SouthAfricaHolidayProviderExtensions
    {
        /// <summary>
        /// Use SouthAfrica holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseSouthAfrica<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<SouthAfricaHolidayProvider>(holidayTypes);
        }
    }
}