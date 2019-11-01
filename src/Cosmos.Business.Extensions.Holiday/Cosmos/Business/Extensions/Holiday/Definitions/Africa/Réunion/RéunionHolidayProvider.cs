using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Réunion.Public;

    /// <summary>
    /// Réunion holiday provider
    /// </summary>
    public class RéunionHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Réunion;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.France;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ReFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ReFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new AbolitionOfSlavery(), //12-20
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ReVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ReVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Réunion"
            };
        }
    }
}