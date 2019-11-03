using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Somalia.Commemoration;
    using Definitions.Africa.Somalia.Public;
    using Definitions.Africa.Somalia.Religion;

    /// <summary>
    /// Somalia holiday provider
    /// </summary>
    public class SomaliaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SomaliaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Somalia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(),//5-1
            new RestorationOfSomalilandSovereignty(),//5-18
            new IndependenceOfBritishSomaliland(),//6-26
            new IndependenceDay(),//7-1
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new DayOfAshura(),
            new BirthdayOfMuhammad(),
            new EndOfRamadan(),
            new FeastOfTheSacrifice(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.rw/home/official_holidays/"
            };
        }
    }
}