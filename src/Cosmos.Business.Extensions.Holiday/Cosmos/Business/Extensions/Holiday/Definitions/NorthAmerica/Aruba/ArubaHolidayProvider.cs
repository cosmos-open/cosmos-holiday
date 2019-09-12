using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Aruba.Public;
    using Definitions.NorthAmerica.Aruba.Religion;
    using Definitions.NorthAmerica.Aruba.Commemoration;

    /// <summary>
    /// Aruba Holiday Provider
    /// </summary>
    public class ArubaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Aruba;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new BeticoCroesDay(), //1-25
            new KingsDay(),//4-27
            new DeraGai(),//6-24
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NationalAnthemAndFlagDay(), //3-8
            new Labour(), //5-1
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.ea.aw/pa/calender/vakantie-di-scol",
                "http://daoaruba.com/pdf/Dia%20nan%20di%20fiesta2016_PAP.pdf",
                "http://www.gobierno.aw/informacion-tocante-servicio/vakantie-di-scol-inclusivo-e-dianan-di-fiesta_42938/"
            };
        }
    }
}