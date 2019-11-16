using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Bonaire.Commemoration;
    using Definitions.NorthAmerica.Bonaire.Public;
    using Definitions.NorthAmerica.Bonaire.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class BonaireHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BonaireRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bonaire;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BqFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BqFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new KingsDay(),//4-27
            new RinconDay_bo(),//4-30 BQ-BO
            new EmancipationDay_se(), //8-1 BQ-SE
            new BonaireDay_bo(), //9-6 BQ-BO
            new StatiaDay_se(),//11-16 BQ-SE
            new StNicholasEve(),//12-5
            new KingdomDay(),//12-15
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BqVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BqVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new LabourDay(), //5-1
            new MothersDay(),//5-2nd-sunday
            new FathersDay(),//6-3rd-sunday
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new AscensionDay(),
            new Carnival_bo(),// BQ-BO
            new Carnival48_bo(),//BQ-BO
            new Carnival48_sa(), //8-1st-monday, BQ-SA
            new SabaDay_sa(),//12-1st-friday,BQ-SA
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.bonairegov.nl/nl/onderwijs/primair/vakantierooster",
                "https://nl.wikipedia.org/wiki/Feestdagen_in_Nederland",
                "https://www.infobonaire.com/annual-events/"
            };
        }
    }
}