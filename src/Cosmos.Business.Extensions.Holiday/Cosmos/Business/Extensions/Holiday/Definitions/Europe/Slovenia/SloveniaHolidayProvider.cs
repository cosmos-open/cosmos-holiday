using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Slovenia.Public;
    using Definitions.Europe.Slovenia.Religion;

    /// <summary>
    /// Slovenia holiday provider
    /// </summary>
    public class SloveniaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SloveniaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Slovenia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = SiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> SiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1 ~ 1-2
            new PrešerenDay(), //2-8
            new DayOfUprisingAgainstOccupation(), //4-27
            new MayDay(), //5-1 ~ 5-2
            new StatehoodDay(), //6-25
            new AssumptionDay(), //8-15
            new ReformationDay(), //10-31
            new DayOfTheDead(), //11-1
            new ChristmasDay(), //12-25
            new IndependenceAndUnityDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = SiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> SiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
            new WhitSunday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Slovenia"
            };
        }
    }
}