using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Oceania;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Oceania.Tonga.Commemoration;
    using Definitions.Oceania.Tonga.Public;
    using Definitions.Oceania.Tonga.Religion;

    /// <summary>
    /// Tonga Holiday Provider
    /// </summary>
    public class TongaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = TongaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Tonga;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Tonga;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;
        
        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ToFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ToFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new AnzacDay(), //4-25
            new KingTupouVI(),//7-4
            new ConstitutionalDay(), //11-4
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ToVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ToVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new EmancipationDay(), //6-4
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.mic.gov.to/news-today/press-releases/7066-tonga-public-holidays-for-2018-"
            };
        }
    }
}