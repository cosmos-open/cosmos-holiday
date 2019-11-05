using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.SaintHelena.Commemoration;
    using Definitions.Africa.SaintHelena.Public;
    using Definitions.Africa.SaintHelena.Religion;

    /// <summary>
    /// SaintHelena holiday provider
    /// </summary>
    public class SaintHelenaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = SaintHelenaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.SaintHelena;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GbShFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GbShFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new SaintHelenaDay(),//5-21
            new ChristmasDay(),//12-25
            new BoxingDay(),//12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GbShVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GbShVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new HolySaturday(),
            new QueensBirthday(),//3-3rd monday
            new WhitMonday(),
            new AscensionDay(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.rw/home/official_holidays/"
            };
        }
    }
}