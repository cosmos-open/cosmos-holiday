using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.Togo.Commemoration;
    using Definitions.Africa.Togo.Public;
    using Definitions.Africa.Togo.Religion;

    /// <summary>
    /// Togo holiday provider
    /// </summary>
    public class TogoHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Togo;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Togo;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = TgFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> TgFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LiberationDay(), //1-13
            new IndependenceDay(), //4-27
            new LabourDay(), //5-1
            new Martyrs(), //6-21
            new Assumption(), //8-15
            new AllSaints(), //11-1
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = TgVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> TgVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterMonday(),
            new WhitMonday(),
            new BirthdayOfMuhammad(),
            new EndOfRamadan(),
            new FeastOfTheSacrifice()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.gov.rw/home/official_holidays/"
            };
        }
    }
}