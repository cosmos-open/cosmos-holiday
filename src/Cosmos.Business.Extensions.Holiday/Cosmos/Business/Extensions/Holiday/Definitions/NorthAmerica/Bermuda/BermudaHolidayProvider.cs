using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Bermuda.Public;
    using Definitions.NorthAmerica.Bermuda.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class BermudaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Bermuda;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BmFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BmFixedHolidayFuncs = new List<IFixedHolidayFunc>();

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BmVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BmVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new BermudaDay(),//friday before 6-1
            new NationalHeroesDay(),//6-3th-monday
            new EmancipationDay(), //thursday before 8-4
            new SomersDay(), //friday before 8-5
            new LabourDay(), //Monday before 9-1
            new RemembranceDay(), //11-11
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bermuda"
            };
        }
    }
}