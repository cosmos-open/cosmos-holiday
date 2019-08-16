using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Belize.Public;
    using Definitions.NorthAmerica.Belize.Religion;
    using Definitions.NorthAmerica.Belize.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class BelizeHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BelizeRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Belize;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Belize;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BzFixedHolidayFuncs = new List<IFixedHolidayFunc>();

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new BaronBlissDay(), //3-9
            new LabourDay(), //5-1
            new CommonwealthDay(), //5-24
            new SaintGeorgesCayeDay(), //9-10
            new IndependenceDay(), //9-21
            new AmericasDay(), //10-12
            new GarifunaSettlementDay(), //11-19
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
            new GoodFriday(),
            new HolySaturday(),
            new EasterSunday(),
            new EasterMonday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Belize"
            };
        }
    }
}