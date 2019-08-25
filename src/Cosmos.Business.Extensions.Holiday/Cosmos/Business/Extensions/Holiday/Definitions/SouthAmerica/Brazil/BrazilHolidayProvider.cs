using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Brazil.Commemoration;
    using Definitions.SouthAmerica.Brazil.Public;
    using Definitions.SouthAmerica.Brazil.Religion;

    /// <summary>
    /// Brazil holiday provider
    /// </summary>
    public class BrazilHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BrazilRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Brazil;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Brazil;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Tiradentes(), //4-21
            new LabourDay(), //5-1
            new IndependenceDay(), //9-7
            new ChildrensDay(), //10-12
            new DayOfTheDead(), //11-2
            new RepublicProclamationDay(), //11-15
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new CorpusChristi(),
            new EasterDay(),
            new PassionOfJesus(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Brazil",
                "https://pt.wikipedia.org/wiki/Feriados_no_Brasil"
            };
        }
    }
}