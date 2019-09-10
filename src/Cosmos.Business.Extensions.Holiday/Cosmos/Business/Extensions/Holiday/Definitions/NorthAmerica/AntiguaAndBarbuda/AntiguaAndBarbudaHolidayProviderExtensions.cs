using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Antigua And Barbuda Holiday Provider Extensions
    /// </summary>
    public static class AntiguaAndBarbudaHolidayProviderExtensions
    {
        /// <summary>
        /// Use Antigua And Barbuda holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseAntiguaAndBarbuda<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<AntiguaAndBarbudaHolidayProvider>(holidayTypes);
        }
    }
}