using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Ukraine.Commemoration;
    using Definitions.Europe.Ukraine.Public;
    using Definitions.Europe.Ukraine.Religion;

    /// <summary>
    /// Ukraine holiday provider
    /// </summary>
    public class UkraineHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = UkraineRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Ukraine;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = UaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> UaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new JulianChristmasDay(), //1-7
            new InternationalWomensDay(), //3-8
            new InternationalWorkersDay(), //5-1
            new VictoryDay(), //5-9
            new ConstitutionDay(), //6-28
            new IndependenceDay(), //8-24
            new DefenderOfUkraineDay(), //10-14
            new ChristmasDay(),
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = UaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> UaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new PentecostSunday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Ukraine"
            };
        }
    }
}