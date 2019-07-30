using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Denmark.Bank;
    using Definitions.Europe.Denmark.Public;
    using Definitions.Europe.Denmark.Religion;

    /// <summary>
    /// Denmark holiday provider
    /// </summary>
    public class DenmarkHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Denmark;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Denmark;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = DkFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> DkFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ConstitutionDay(), //6-5
            new ChristmasEve(), //12-24
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = DkVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> DkVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MaundyThursday(),
            new EasterSunday(),
            new EasterMonday(),
            new GoodFriday(),
            new GeneralPrayerDay(),
            new AscensionDay(),
            new BankClosingDay(),
            new Pentecost(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Denmark",
            };
        }
    }
}