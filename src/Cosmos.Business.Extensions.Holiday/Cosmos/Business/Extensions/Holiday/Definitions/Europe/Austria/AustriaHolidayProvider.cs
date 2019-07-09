using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Austria.Commemoration;
    using Definitions.Europe.Austria.Public;
    using Definitions.Europe.Austria.Religion;

    /// <summary>
    /// Austria holiday provider
    /// </summary>
    public class AustriaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = AustriaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Austria;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AtFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AtFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new ImmaculateConception(), //5-1
            new NationalHoliday(), //5-1
            new AssumptionDay(), //8-15
            new NationalHoliday2(), //10-26
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AtVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AtVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new AscensionDay(),
            new CorpusChristi(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Austria"
            };
        }
    }
}