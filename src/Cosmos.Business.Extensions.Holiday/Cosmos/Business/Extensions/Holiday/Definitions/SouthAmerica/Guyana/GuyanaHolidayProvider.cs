using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.SouthAmerica.Guyana.Commemoration;
    using Definitions.SouthAmerica.Guyana.Public;
    using Definitions.SouthAmerica.Guyana.Religion;

    /// <summary>
    /// Guyana holiday provider
    /// </summary>
    public class GuyanaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = GuyanaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Guyana;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Guyana;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GyFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GyFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new RepublicDay(), //2-23
            new LabourDay(), //5-1
            new ArrivalDay(), //5-5
            new IndependenceDay(), //5-26
            new EmancipationDay(), //8-1
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GyVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GyVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CaricomDay(), //7-1st-monday
            new GoodFriday(),
            new EasterMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Guyana"
            };
        }
    }
}