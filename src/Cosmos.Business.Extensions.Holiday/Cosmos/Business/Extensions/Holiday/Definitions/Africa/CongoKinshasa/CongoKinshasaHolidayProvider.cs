using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Africa;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Africa.CongoKinshasa.Commemoration;
    using Definitions.Africa.CongoKinshasa.Public;
    using Definitions.Africa.CongoKinshasa.Religion;

    /// <summary>
    /// CongoKinshasa holiday provider
    /// </summary>
    public class CongoKinshasaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = CongoKinshasaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.CongoKinshasa;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.CongoKinshasa;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CdFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CdFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new ChristmasDay(), //12-25
            new PublicHoliday20160115(), //2016-01-15
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CdVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CdVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MartyrsDay(), //1-4
            new AnniversaryOfPresidentLaurentKabila(), //1-16
            new AnniversaryOfPrimeMinisterPatriceEmeryLumumba(), //1-17
            new LabourDay(), //5-1
            new LiberationDay(), //5-17
            new IndependenceDay(), //6-30
            new ParentsDay(), //8-1
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.ilo.org/dyn/natlex/docs/ELECTRONIC/101405/122159/F1802609849/COD-101405.pdf"
            };
        }
    }
}