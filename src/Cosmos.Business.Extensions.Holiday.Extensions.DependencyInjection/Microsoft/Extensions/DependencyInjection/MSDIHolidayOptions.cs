using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Configuration;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Holiday options for MS DI
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class MSDIHolidayOptions : HolidayOptions<MSDIHolidayOptions>
    {
        /// <summary>
        /// RuntimeFixedHolidayFuncs
        /// </summary>
        internal IReadOnlyList<RuntimeFixedHolidayFunc> RuntimeFixedHolidayFuncs => _RuntimeFixedHolidayFuncs;

        /// <summary>
        /// BizWeekendDefinitions
        /// </summary>
        internal IReadOnlyList<IBizWeekendDefinition> BizWeekendDefinitions => _bizWeekendDefinitions;

        /// <summary>
        /// WeekendUnlinkedAssembliesPattern
        /// </summary>
        internal string WeekendUnlinkedAssembliesPattern => _WeekendUnlinkedAssembliesPattern;

        /// <summary>
        /// WeekendIncludeExtendDefinitions
        /// </summary>
        internal bool WeekendIncludeExtendDefinitions => _WeekendIncludeExtendDefinitions;
    }
}