using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Gibraltar.Public;

    /// <summary>
    /// Gibraltar holiday provider
    /// </summary>
    public class GibraltarHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Gibraltar;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new WorkersMemorialDay(),//4-28
            new LabourDay(), //5-1
            new GibraltarNationalDay(),//9-10
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new CommonwealthDay(),//4-2nd-monday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://www.gibraltar.gov.gi/new/bank-public-holidays-2015",
                "https://www.gibraltar.gov.gi/new/bank-public-holidays-2016",
                "https://www.gibraltar.gov.gi/new/bank-holidays-2017"
            };
        }
    }
}