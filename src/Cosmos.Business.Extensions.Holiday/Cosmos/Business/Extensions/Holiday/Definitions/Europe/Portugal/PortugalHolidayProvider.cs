using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Portugal.Commemoration;
    using Definitions.Europe.Portugal.Public;
    using Definitions.Europe.Portugal.Religion;
    using Definitions.Europe.Portugal.Tradition;

    /// <summary>
    /// Portugal holiday provider
    /// </summary>
    public class PortugalHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Portugal;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PtFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PtFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new SolemnityOfMary_MotherOfGod(), //1-1
            new FreedomDay(), //4-25
            new LabourDay(), //5-1
            new AzoresDay(), //6-1
            new NationalDay(), //6-10
            new MadeiraDay(), //7-1
            new AssumptionDay(), //8-15
            new RepublicDay(), //10-5
            new AllSaintsDay(), //11-1
            new RestorationOfIndependence(), //12-1    
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PtVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PtVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new EasterDay(),
            new GoodFriday(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Portugal"
            };
        }
    }
}