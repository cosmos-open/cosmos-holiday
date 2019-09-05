using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Asia;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.UnitedArabEmirates.Commemoration;
    using Definitions.Asia.UnitedArabEmirates.Public;
    using Definitions.Asia.UnitedArabEmirates.Religion;

    /// <summary>
    /// UnitedArabEmirates holiday provider
    /// </summary>
    public class UnitedArabEmiratesHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = UnitedArabEmiratesRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.UnitedArabEmirates;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedArabEmirates;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AeFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AeFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new CommemorationDay(), //12-1
            new NationalDay(), //12-2 ~ 12-3
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AeVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AeVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EidAlFitrEndOfRamadan(),
            new DayOfArafah(),
            new DayOfTheSacrifice(),
            new IslamicNewYear(),

        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_United_Arab_Emirates"
            };
        }
    }
}