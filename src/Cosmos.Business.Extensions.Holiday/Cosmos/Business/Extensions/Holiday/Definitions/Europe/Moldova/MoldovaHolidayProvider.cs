using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Moldova.Commemoration;
    using Definitions.Europe.Moldova.Public;
    using Definitions.Europe.Moldova.Religion;

    /// <summary>
    /// Moldova holiday provider
    /// </summary>
    public class MoldovaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = MoldovaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Moldova;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MdFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MdFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new OrthodoxChristmasDay(), //1-7 ~ 1-8
            new DayOfVeterans(), //2-23
            new InternationalWomensDay(), //3-8
            new LabourDay(),
            new VictoryAndCommemorationDay(), //5-9
            new BălţiDay(), //5-22
            new IndependenceDay(), //8-27
            new NationalLanguageDay(), //8-31
            new NationalArmyDay(), //9-3
            new CapitalsDay(), //10-14
            new SouthCapitalsDayCahul(), //11-21
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MdVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MdVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new OrthodoxEaster(),
            new MemorialDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Moldova"
            };
        }
    }
}