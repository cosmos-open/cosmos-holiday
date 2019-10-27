using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.EquatorialGuinea.Public;

    /// <summary>
    /// EquatorialGuinea holiday provider
    /// </summary>
    public class EquatorialGuineaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.EquatorialGuinea;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.EquatorialGuinea;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GqFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GqFixedHolidayFuncs = new List<IFixedHolidayFunc>();

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GqVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GqVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new PresidentsDay(), //6-5
            new ArmedForcesDay(), //8-3
            new ConstitutionDay(), //8-15
            new IndependenceDay(), //10-12
            new ImmaculateConception(), //12-8
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Equatorial_Guinea",
                "https://es.wikipedia.org/wiki/Guinea_Ecuatorial",
                "https://leydeguinea.files.wordpress.com/2014/08/013_boletin-oficial-del-estado-2.pdf"
            };
        }
    }
}