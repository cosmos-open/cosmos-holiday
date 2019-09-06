using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Anguilla.Public;
    using Definitions.NorthAmerica.Anguilla.Religion;
    using Definitions.NorthAmerica.Anguilla.Commemoration;

    /// <summary>
    /// Anguilla Holiday Provider
    /// </summary>
    public class AnguillaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Anguilla;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AiFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AiFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new JamesRonaldWebsterDay(), //3-2
            new Labour(), //5-1
            new NationalHeroesAndHeroinesDay(), //12-19
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AiVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AiVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Queen(), //6-2nd-monday
            new AugustMonday(), //8-1st-monday
            new AugustThursday(), //8-1st-thursday
            new ConstitutionDay(), //8-1st-friday
            new EasterMonday(),
            new GoodFriday(),
            new WhitSunday(),
            new WhitMonday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.ai/holiday.php"
            };
        }
    }
}