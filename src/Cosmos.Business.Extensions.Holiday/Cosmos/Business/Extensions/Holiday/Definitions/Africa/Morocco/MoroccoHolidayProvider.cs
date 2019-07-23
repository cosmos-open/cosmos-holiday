using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Morocco.Public;

    /// <summary>
    /// Morocco holiday provider
    /// </summary>
    public class MoroccoHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = MoroccoRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Morocco;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Morocco;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ProclamationOfIndependence(), //1-11
            new LabourDay(), //5-1
            new Enthronement(), //7-30
            new ZikraOuedEdDahab(), //8-14    
            new RevolutionDay(), //8-20
            new YouthDay(), //8-21
            new GreenMarch(), //11-6
            new IndependenceDay(), //11-18
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MaVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Morocco",
                "http://www.dniwolne.eu/zn-%E9%9D%9E%E6%B4%B2-%E5%81%87%E6%9C%9F-%E6%91%A9%E6%B4%9B%E5%93%A5.html"
            };
        }
    }
}