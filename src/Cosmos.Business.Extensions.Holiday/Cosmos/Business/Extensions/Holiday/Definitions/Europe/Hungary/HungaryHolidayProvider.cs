using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Hungary.Commemoration;
    using Definitions.Europe.Hungary.Public;
    using Definitions.Europe.Hungary.Religion;
    using Definitions.Europe.Hungary.Tradition;

    /// <summary>
    /// Hungary holiday provider
    /// </summary>
    public class HungaryHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Hungary;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Hungary;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new _1848RevolutionMemorialDay(), //3-15
            new LabourDay(), //5-1
            new StateFoundationDay(), //8-20
            new _1956RevolutionMemorialDay(), //10-23
            new AllSaintsDay(), //11-1
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new Pentecost(),
            new WhitMonday()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Hungary",
            };
        }
    }
}