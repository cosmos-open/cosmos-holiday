using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Armenia.Commemoration;
    using Definitions.Asia.Armenia.Public;
    using Definitions.Asia.Armenia.Religion;
    using Definitions.Asia.Armenia.School;

    /// <summary>
    /// Armenia holiday provider
    /// </summary>
    public class ArmeniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = ArmeniaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Armenia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AmFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1 ~ 1-2
            new PreChristmasHolidays(), //1-3 ~ 1-5
            new ChristmasDay(), //1-6
            new ArmyDay(), //1-28
            new MotherLanguageDay(), //2-21
            new WomaesDay(),//3-8
            new MotherhoodAndBeautyDay(),//4-7
            new MothersDay(),//4-24
            new LabourDay(), //5-1
            new YerkrapahDay(),//5-8
            new VictoryAndPeaceDay(),//5-9
            new RepublicDay(),//5-28
            new ChildrenRights(),//6-1
            new ConstitutionDay(),//7-5
            new KnowledgeLiteracyAndEducationDay(),//9-1
            new IndependenceDay(), //9-1
            new EarthquakeRemembranceDay(),//12-7
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new StVartanAndDutyDays(),
            new TranslatorsDay(),//10-2nd-saturday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Armenia",
            };
        }
    }
}