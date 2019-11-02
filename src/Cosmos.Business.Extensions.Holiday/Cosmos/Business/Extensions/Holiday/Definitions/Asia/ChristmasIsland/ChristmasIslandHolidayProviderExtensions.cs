using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// ChristmasIsland holiday provider extensions
    /// </summary>
    public static class ChristmasIslandHolidayProviderExtensions
    {
        /// <summary>
        /// Use ChristmasIsland holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseChristmasIsland<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<ChristmasIslandHolidayProvider>(holidayTypes);
        }
    }
}