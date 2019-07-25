using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Spain.Commemoration;
    using Definitions.Europe.Spain.Public;
    using Definitions.Europe.Spain.Religion;
    using Definitions.Europe.Spain.Tradition;

    /// <summary>
    /// Spain holiday provider
    /// </summary>
    public class SpainHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Spain;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = EsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> EsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new RegionalHoliday_an0228(), //2-28
            new RegionalHoliday_ib0301(), //3-1
            new StJosephsDay(), //3-19
            new RegionalHoliday_ar0423(), //4-23
            new RegionalHoliday_cl0423(), //4-23
            new LabourDay(), //5-1
            new RegionalHoliday__m0502(), //5-2
            new RegionalHoliday_ga0517(), //5-17
            new RegionalHoliday_ic0530(), //5-30
            new RegionalHoliday_cm0531(), //5-31
            new RegionalHoliday_lo0609(), //6-9
            new RegionalHoliday_mu0609(), //6-9
            new StJoansDay(), //6-24
            new SaintJamesDay(), //7-25
            new Assumption(), //8-15
            new MunicipalHoliday(), //9-2
            new RegionalHoliday_ex0908(), //9-8
            new RegionalHoliday__o0908(), //9-8
            new NationalDayOfCatalonia(), //9-11
            new RegionalHoliday_cb0915(), //9-15
            new RegionalHoliday_vc1009(), //10-9
            new ConstitutionDay(), //12-6
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = EsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> EsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11-1st-monday
            new CorpusChristi(),
            new EasterMonday(),
            new EasterSunday(),
            new GoodFriday(),
            new MaundyThursday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Spain"
            };
        }
    }
}