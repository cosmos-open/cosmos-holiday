using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Andorra.Commemoration;
    using Definitions.Europe.Andorra.Public;
    using Definitions.Europe.Andorra.Religion;
    using Definitions.Europe.Andorra.Tradition;

    /// <summary>
    /// Andorra holiday provider
    /// </summary>
    public class AndorraHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = AndorraRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Andorra;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Andorra;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AdFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AdFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new Carnival(), //2-12
            new ConstitutionDay(), //3-14
            new Labour(), //5-1
            new CanilloAnnualFestival(), //7-21 ~ 7-23
            new EscaldesEngordanyAnnualFestival(), //7-15 ~ 7-26
            new SantJuliàDeLòriaAnnualFestival(), //7-27 ~ 7-30
            new AssumptionDay(), //8-15
            new EncampAnnualFestival(), //8-15 ~ 8-16
            new LaMassanaAnnualFestival(), //8-15 ~ 8-16
            new OrdinoAnnualFestival(), //8-15 ~ 8-16
            new NationalDay(), //9-8
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AdVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AdVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterMonday(),
            new WhitMonday(),
            new AllSaintsDay(), //11-1st-saturday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Andorra"
            };
        }
    }
}