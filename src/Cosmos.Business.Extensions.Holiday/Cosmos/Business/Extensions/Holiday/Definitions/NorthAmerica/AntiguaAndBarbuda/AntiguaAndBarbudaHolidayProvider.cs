using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.AntiguaAndBarbuda.Public;
    using Definitions.NorthAmerica.AntiguaAndBarbuda.Religion;
    using Definitions.NorthAmerica.AntiguaAndBarbuda.Commemoration;

    /// <summary>
    /// Antigua And Barbuda Holiday Provider
    /// </summary>
    public class AntiguaAndBarbudaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = AntiguaAndBarbudaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.AntiguaAndBarbuda;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Labour(),//5-1
            new JOuvertMorning(),//8-1
            new VcBirdDay(),//12-9
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new IndependenceDay(), //11-1
            new EasterMonday(),
            new GoodFriday(),
            new WhitMonday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.ab.gov.ag/detail_page.php?page=4",
                "http://www.laws.gov.ag/acts/2005/a2005-8.pdf"
            };
        }
    }
}