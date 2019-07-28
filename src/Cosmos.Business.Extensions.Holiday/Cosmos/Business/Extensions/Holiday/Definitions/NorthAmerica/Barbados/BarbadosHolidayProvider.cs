using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Barbados.Public;
    using Definitions.NorthAmerica.Barbados.Religion;
    using Definitions.NorthAmerica.Barbados.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class BarbadosHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BarbadosRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Barbados;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Barbados;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BbFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BbFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new NationalHeroesDay(), //4-28
            new EmancipationDay(), //8-1
            new IndependenceDay(), //11-30
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BbVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BbVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {

            new EasterMonday(),
            new GoodFriday(),
            new WhitMonday(),
            new KadoomentDay(), //8-1st-monday
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Barbados"
            };
        }
    }
}