using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Germany.Commemoration;
    using Definitions.Europe.Germany.Public;
    using Definitions.Europe.Germany.Religion;
    using Definitions.Europe.Germany.Tradition;

    /// <summary>
    /// Germany holiday provider
    /// </summary>
    public class GermanyHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = GermanyRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Germany;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = DeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> DeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new InternationalWomensDay(), //3-8
            new LabourDay(), //5-1
            new AssumptionDay(), //8-15
            new GermanUnityDay(), //10-3
            new ReformationDay2016Before(), //10-31
            new ReformationDay2017(), //10-31
            new ReformationDay2018After(), //10-31
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = DeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> DeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11月第一个周六
            new GoodFriday(),
            new EasterMonday(),
            new AscensionDay(),
            new CorpusChristi(),
            new WhitMonday(),
            new RepentanceAndPrayerDay3438(),
            new RepentanceAndPrayerDay4580(),
            new RepentanceAndPrayerDay8189(),
            new RepentanceAndPrayerDay9094(),
            new RepentanceAndPrayerDay95(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://de.wikipedia.org/wiki/Gesetzliche_Feiertage_in_Deutschland"
            };
        }
    }
}