using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Estonia.Commemoration;
    using Definitions.Europe.Estonia.Public;
    using Definitions.Europe.Estonia.Religion;

    /// <summary>
    /// Estonia holiday provider
    /// </summary>
    public class EstoniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = EstoniaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Estonia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = EeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> EeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new AnniversaryOfTheTartuPeaceTreaty(), //2-2
            new IndependenceDay(), //2-24
            new NativeLanguageDay(), //3-14
            new SpringDay(), //5-1
            new NationalFlagDay(), //6-4
            new DayOfMourningAndCommemoration(), //6-14
            new VictoryDay(), //6-23
            new MidsummerDay(), //6-24
            new DayOfRestorationOfIndependence(), //8-20
            new EuropeanDay(), //8-23
            new ResistanceFightingDay(), //9-22
            new AllSoulsDay(), //11-2
            new DayOfDeclarationOfSovereignty(), //11-16
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = EeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> EeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new Pentecost(),
            new GoodFriday(),
            new MothersDay(), //5-2nd-sunday
            new GrandparentsDay(), //9-2nd-sunday
            new FathersDay(), //11-2nd-sunday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Estonia",
            };
        }
    }
}