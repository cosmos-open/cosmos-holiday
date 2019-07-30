using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Cuba.Public;
    using Definitions.NorthAmerica.Cuba.Religion;
    using Definitions.NorthAmerica.Cuba.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class CubaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CubaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Cuba;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Cuba;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CuFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CuFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new VictoryOfFidelCastro(), //1-2
            new LabourDay(), //5-1
            new AssaultOfTheMoncadaGarrisonBefore(), //7-25
            new AssaultOfTheMoncadaGarrison(), //7-26
            new AssaultOfTheMoncadaGarrisonAfter(), //7-27
            new IndependenceDay(), //10-10
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CuVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CuVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Cuba",
            };
        }
    }
}