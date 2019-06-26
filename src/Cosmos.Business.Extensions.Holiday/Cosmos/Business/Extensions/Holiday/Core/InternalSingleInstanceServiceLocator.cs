using System;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Internal single instance service locator
    /// </summary>
    public static class InternalSingleInstanceServiceLocator
    {
        private static IHolidayProviderManager HolidayProviderManagerCache { get; set; }

        /// <summary>
        /// Sets
        /// </summary>
        /// <param name="manager"></param>
        public static void SetHolidayProviderManager(IHolidayProviderManager manager)
        {
            HolidayProviderManagerCache = manager ?? throw new ArgumentNullException(nameof(manager));
        }

        /// <summary>
        /// Gets
        /// </summary>
        public static IHolidayProviderManager HolidayProviderManager => HolidayProviderManagerCache;
    }
}