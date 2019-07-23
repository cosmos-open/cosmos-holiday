using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.ElSalvador.Commemoration;
    using Definitions.Africa.ElSalvador.Public;
    using Definitions.Africa.ElSalvador.Religion;

    /// <summary>
    /// ElSalvador holiday provider
    /// </summary>
    public class ElSalvadorHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.ElSalvador;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SvFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SvFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new LabourDay(), //5-1
            new TheDayOfTheCross(), //5-3
            new SoldiersDay(), //5-7
            new MothersDay(), //5-10
            new FathersDay(), //5-10
            new AugustFestivals(), //8-1 ~ 8-7
            new IndependenceDay(), //9-15
            new ChildrensDay(), //10-1
            new EthnicPrideDay(), //10-12
            new DayOfTheDead(), //11-2
            new NationalPupusaFestival(), //11-7 ~ 11-13
            new DayOfTheQueenOfPeace(), //11-21
            new ChristmasDay(), //12-25
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SvVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SvVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/El_Salvador#Public_holidays",
            };
        }
    }
}