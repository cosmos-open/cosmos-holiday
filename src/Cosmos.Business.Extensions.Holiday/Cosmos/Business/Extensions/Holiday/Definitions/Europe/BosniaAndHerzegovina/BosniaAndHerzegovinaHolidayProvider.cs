using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Europe;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.BosniaAndHerzegovina.Commemoration;
    using Definitions.Europe.BosniaAndHerzegovina.Public;
    using Definitions.Europe.BosniaAndHerzegovina.Religion;
    using Definitions.Europe.BosniaAndHerzegovina.Tradition;

    /// <summary>
    /// BosniaAndHerzegovina holiday provider
    /// </summary>
    public class BosniaAndHerzegovinaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = BosniaAndHerzegovinaRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = BaFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> BaFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new Epiphany(), //1-6
            new RepublicDay(), //1-9
            new IndependenceDay(), //3-1
            new Establishment(), //3-8
            new LabourDay(), //5-1
            new VictoryDay(), //5-9
            new Assumption(), //8-15
            new AllSaintsDay(), //11-1
            new AllSoulsDay(), //11-2
            new DaytonAgreementDay(),//11-21
            new StatehoodDay(), //11-25
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = BaVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> BaVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
            new CorpusChristi(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Bosnia_and_Herzegovina",
                "http://www.mhrr.gov.ba/PDF/LjudskaPrava/The%20Fourt%20Report%20of%20BH%20on%20implementation%20of%20the%20ESCR.pdf"
            };
        }
    }
}