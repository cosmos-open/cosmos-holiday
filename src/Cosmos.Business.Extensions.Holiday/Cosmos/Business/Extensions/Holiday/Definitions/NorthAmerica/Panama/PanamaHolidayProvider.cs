using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Panama.Public;
    using Definitions.NorthAmerica.Panama.Religion;
    using Definitions.NorthAmerica.Panama.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class PanamaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Panama;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Panama;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = PaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> PaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MartyrsDay(), //1-9
            new LabourDay(), //5-1
            new SeparationDay(), //11-3
            new FlagDay(), //11-4
            new ColonDay(), //11-5
            new ShoutInVillaDeLosSantos(), //11-10
            new IndependenceDay(), //11-28
            new MothersDay(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = PaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> PaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new Carnival(),
            new Carnival48(),
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Panama"
            };
        }
    }
}