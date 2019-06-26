using System;

namespace Cosmos.Business.Extensions.Holiday.Core.Internals
{
    /// <summary>
    /// Internal single instance service locator
    /// </summary>
    public static class InternalSingleInstanceServiceLocator
    {
        private static IHolidayProviderManager HolidayProviderManagerCache { get; set; }
        private static IHolidayManager HolidayManagerCache { get; set; }

        /// <summary>
        /// Sets
        /// </summary>
        /// <param name="manager"></param>
        public static void SetHolidayProviderManager(IHolidayProviderManager manager)
        {
            HolidayProviderManagerCache = manager ?? throw new ArgumentNullException(nameof(manager));
        }

        /// <summary>
        /// Sets
        /// </summary>
        /// <param name="manager"></param>
        public static void SetHolidayManager(IHolidayManager manager)
        {
            HolidayManagerCache = manager ?? throw new ArgumentNullException(nameof(manager));
        }

        /// <summary>
        /// Gets
        /// </summary>
        public static IHolidayProviderManager HolidayProviderManager => HolidayProviderManagerCache;

        /// <summary>
        /// Gets
        /// </summary>
        public static IHolidayManager HolidayManager => HolidayManagerCache;
    }
}