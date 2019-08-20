using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.CostaRica.Public;
    using Definitions.NorthAmerica.CostaRica.Religion;
    using Definitions.NorthAmerica.CostaRica.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class CostaRicaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CostaRicaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CostaRica;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new JuanSantaMariaDay(), //4-12
            new LabourDay(), //5-1
            new GuanacasteDay(), //7-25
            new VirginOfLosAngelesDay(), //8-2
            new MothersDay(), //8-15
            new IndependenceDay(), //9-15
            new CulturesNationalDay(), //10-12
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MaundyThursday(),
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Costa_Rica",
            };
        }
    }
}