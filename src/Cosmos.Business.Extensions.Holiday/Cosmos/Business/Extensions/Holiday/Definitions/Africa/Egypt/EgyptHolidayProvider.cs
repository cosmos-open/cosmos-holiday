using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Egypt.Commemoration;
    using Definitions.Africa.Egypt.Public;
    using Definitions.Africa.Egypt.Religion;

    /// <summary>
    /// Egypt holiday provider
    /// </summary>
    public class EgyptHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = EgyptRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Egypt;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Egypt;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = EgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> EgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new Christmas(), //1-7
            new RevolutionDay2011(), //1-25
            new SinaiLiberationDay(), //4-25
            new LabourDay(), //5-1
            new RevolutionDay(), //7-23
            new ArmedForcesDay(), //10-6
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = EgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> EgVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Egypt",
            };
        }
    }
}