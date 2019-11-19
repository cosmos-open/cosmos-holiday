using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Curaçao.Public;
    using Definitions.NorthAmerica.Curaçao.Religion;
    using Definitions.NorthAmerica.Curaçao.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class CuraçaoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Curaçao;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new KingsDay(), //4-27
            new LabourDay(), //5-1
            new FlagDay(), //7-2
            new CuraçaoDay(), //10-10
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
            new NewYearsEve(), //12-31
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CarnivalMonday(),
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new MothersDay(), //5-2nd-monday
            new FathersDay(), //6-1st-sunday
            new AscensionDay(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://loketdigital.gobiernu.cw/Loket/prodcat/products/getProductDetailsAction.do?id=437",
            };
        }
    }
}