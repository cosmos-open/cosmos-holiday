using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.SaintBarts.Public;
    using Definitions.NorthAmerica.SaintBarts.Religion;
    using Definitions.NorthAmerica.SaintBarts.Tradition;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class SaintBartsHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SaintBarts;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BlFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BlFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new VictoryDay(),//5-8
            new NationalDay(),//7-14
            new AssumptionDay(),//8-15
            new SaintBarth(),//8-24
            new AllSaintsDay(), //11-1
            new ArmisticeDay(), //11-11
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BlVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BlVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new AshWednesday(),
            new LaetareSunday(),
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new AscensionDay(),
            new WhitSunday(),
            new WhitMonday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Saint_Barth%C3%A9lemy#Festivals_and_holidays"
            };
        }
    }
}