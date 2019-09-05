using Cosmos.Business.Extensions.Holiday.Configuration;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// UnitedArabEmirates holiday provider extensions
    /// </summary>
    public static class UnitedArabEmiratesHolidayProviderExtensions
    {
        /// <summary>
        /// Use UnitedArabEmirates holiday provider
        /// </summary>
        /// <param name="options"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TOptions"></typeparam>
        /// <returns></returns>
        public static TOptions UseUnitedArabEmirates<TOptions>(this HolidayOptions<TOptions> options, params HolidayType[] holidayTypes) where TOptions : HolidayOptions<TOptions>
        {
            return options.Use<UnitedArabEmiratesHolidayProvider>(holidayTypes);
        }
    }
}