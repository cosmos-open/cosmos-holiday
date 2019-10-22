using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Colombia.Commemoration;
    using Definitions.SouthAmerica.Colombia.Public;
    using Definitions.SouthAmerica.Colombia.Religion;
    using Definitions.SouthAmerica.Colombia.Tradition;

    /// <summary>
    /// Colombia holiday provider
    /// </summary>
    public class ColombiaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = ColombiaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Colombia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Colombia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new SaintJosephsDay(), //3-19
            new LabourDay(), //5-1
            new SaintPeterAndSaintPaul(), //6-29
            new DeclarationOfIndependence(), //7-20
            new BattleOfBoyacá(), //8-7
            new AssumptionOfMary(), //8-15
            new ColumbusDay(), //10-12
            new AllSaintsDay(), //11-1
            new IndependenceOfCartagena(), //11-11
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new GoodFriday(),
            new PalmSunday(),
            new MaundyThursday(),
            new EasterSunday(),
            new AscensionDay43(),
            new CorpusChristi64(),
            new SacredHeart71(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Colombia",
            };
        }
    }
}