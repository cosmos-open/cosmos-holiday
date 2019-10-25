using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.CapeVerde.Public;
    using Definitions.Africa.CapeVerde.Religion;
    using Definitions.Africa.CapeVerde.Tradition;

    /// <summary>
    /// CapeVerde holiday provider
    /// </summary>
    public class CapeVerdeHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CapeVerdeRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CapeVerde;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.CapeVerde;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CvFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CvFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new DemocracyDay(),//1-13
            new HeroesDay(),//1-20
            new LabourDay(), //5-1
            new ChildrenDay(),//6-1
            new IndependenceDay(),//7-5
            new NationalDay(), //5-20
            new AssumptionDay(), //8-15
            new NationalDay(),//9-12
            new AllSaintsDay(),//11-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CvVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CvVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CarnivalTuesday(),//easter-47
            new AshWednesday(),//easter-46
            new GoodFriday(),//easter-2
            new EasterSunday(),//easter
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://pt.wikipedia.org/wiki/Cabo_Verde#Feriados",
                "http://www.governo.cv/documents/dia_do_municpio_da_praia.pdf"
            };
        }
    }
}