using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Monaco.Commemoration;
    using Definitions.Europe.Monaco.Public;
    using Definitions.Europe.Monaco.Religion;
    using Definitions.Europe.Monaco.Tradition;

    /// <summary>
    /// Monaco holiday provider
    /// </summary>
    public class MonacoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Monaco;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Monaco;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = McFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> McFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new SaintDevotasDay(), //1-27
            new MayDay(),
            new AssumptionDay(), //8-15
            new ImmaculateConception(), //12-8
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = McVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> McVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new AscensionDay(),
            new WhitMonday(),
            new CorpusChristi(),
            new NewYearsDay(), //1-1
            new AllSaintsDay(), //11-1
            new NationalDay(), //11-19
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Monaco"
            };
        }
    }
}