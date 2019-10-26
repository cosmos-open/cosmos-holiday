using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Dominica.Public;
    using Definitions.NorthAmerica.Dominica.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class DominicaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = DominicaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Dominica;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Dominica;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = DoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> DoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new IndependenceDay(), //11-3
            new NationalDay(),//11-4
            new ChristmasDay(), //12-25
            new BoxingDay(),//12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = DoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> DoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new Pentecost(),
            new WhitMonday(),
            new EmancipationDay(),//8-1st-monday
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Dominica",
            };
        }
    }
}