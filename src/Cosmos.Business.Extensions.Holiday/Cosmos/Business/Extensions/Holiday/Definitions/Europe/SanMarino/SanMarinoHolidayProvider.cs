using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.SanMarino.Commemoration;
    using Definitions.Europe.SanMarino.Public;
    using Definitions.Europe.SanMarino.Religion;
    using Definitions.Europe.SanMarino.Tradition;

    /// <summary>
    /// SanMarino holiday provider
    /// </summary>
    public class SanMarinoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SanMarinoRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SanMarino;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.SanMarino;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SmFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new FeastOfSaintAgatha(), //2-5
            new AnniversaryOfTheArengo(), //3-25
            new LabourDay(), //5-1
            new LiberationFromFascism(), //7-28
            new Assumption(), //8-15
            new FeastOfSanMarinoAndTheRepublic(), //9-3
            new AllSaintsDay(), //11-1
            new CommemorationOfAllThoseWhoDiedAtWar(), //9-3
            new ImmaculateConception(), //12-8
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new EasterSunday(),
            new CorpusChristi(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/San_Marino#Public_holidays_and_festivals"
            };
        }
    }
}