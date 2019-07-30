using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Croatia.Commemoration;
    using Definitions.Europe.Croatia.Public;
    using Definitions.Europe.Croatia.Religion;
    using Definitions.Europe.Croatia.Tradition;

    /// <summary>
    /// Croatia holiday provider
    /// </summary>
    public class CroatiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Croatia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Croatia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = HrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> HrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new InternationalWorkersDay(), //5-1
            new AntiFascistStruggleDay(), //6-22
            new StatehoodDay(), //6-25
            new Victory(), //8-5
            new AssumptionDay(), //8-15
            new IndependenceDay(), //10-8
            new AllSaintsDay(), //11-1
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = HrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> HrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
            new CorpusChristi(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Croatia",
            };
        }
    }
}