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
    using Definitions.NorthAmerica.Mexico.Public;
    using Definitions.NorthAmerica.Mexico.Commemoration;
    using Definitions.NorthAmerica.Mexico.Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class MexicoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Mexico;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Mexico;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MxFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MxFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MxVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MxVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ConstitutionDay(), //2-1st-monday
            new BenitoJuárezsBirthday(), //4-3rd-monday
            new LabourDay(), //5-1
            new IndependenceDay(), //11-3rd-monday
            new InaugurationDay(), //12-1
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Mexico"
            };
        }
    }
}