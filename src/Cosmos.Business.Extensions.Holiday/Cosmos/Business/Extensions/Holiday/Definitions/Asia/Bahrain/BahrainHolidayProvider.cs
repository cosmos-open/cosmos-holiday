using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Bahrain.Commemoration;
    using Definitions.Asia.Bahrain.Public;
    using Definitions.Asia.Bahrain.Religion;

    /// <summary>
    /// Bahrain holiday provider
    /// </summary>
    public class BahrainHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BahrainRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bahrain;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Bahrain;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BhFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BhFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NationalDay(), //12-16
            new AccessionDay(),//12-17
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BhVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BhVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new IslamicNewYear(),
            new DayOfAshura(),
            new BirthdayOfMuhammad(),
            new EndOfRamadan(),
            new ArafatDay(),
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
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bahrain"
            };
        }
    }
}