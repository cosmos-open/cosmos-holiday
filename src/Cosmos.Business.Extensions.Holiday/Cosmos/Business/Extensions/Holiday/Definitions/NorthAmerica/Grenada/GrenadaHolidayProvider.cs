using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Grenada.Commemoration;
    using Definitions.NorthAmerica.Grenada.Public;
    using Definitions.NorthAmerica.Grenada.Religion;

    /// <summary>
    /// Grenada Holiday Provider
    /// </summary>
    public class GrenadaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = GrenadaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Grenada;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Grenada;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GdFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GdFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new IndependenceDay(), //2-7
            new LabourDay(), //5-1
            new IndianArrivalDay(), //5-1
            new Carnival(), //8-11
            new ThanksgivingDay(), //10-25
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GdVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GdVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterMonday(),
            new WhitMonday(),
            new CorpusChristi(),
            new EmancipationDay(), //8-1
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Grenada",
            };
        }
    }
}