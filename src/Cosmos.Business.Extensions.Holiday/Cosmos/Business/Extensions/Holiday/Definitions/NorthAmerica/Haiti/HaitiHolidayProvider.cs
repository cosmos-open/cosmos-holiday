using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Haiti.Public;
    using Definitions.NorthAmerica.Haiti.Religion;
    using Definitions.NorthAmerica.Haiti.Commemoration;
    using Definitions.NorthAmerica.Haiti.Tradition;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class HaitiHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Haiti;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Haiti;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = HtFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> HtFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new AncestryDay(), //1-2
            new Epiphany(), //1-6
            new LabourAndAgricultureDay(), //5-1
            new FlagAndUniversitiesDay(), //5-18
            new AssumptionDay(), //8-15
            new DessalinesDay(), //10-17
            new AllSaintsDay(), //11-1
            new AllSoulsDay(), //11-2
            new BattleOfVertièresDay(), //11-18
            new DiscoveryDay(), //12-5
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = HtVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> HtVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new AshWednesday(),
            new MaundyThursday(),
            new GoodFriday(),
            new EasterSunday(),
            new AscensionDay(),
            new CorpusChristi(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Haiti",
            };
        }
    }
}