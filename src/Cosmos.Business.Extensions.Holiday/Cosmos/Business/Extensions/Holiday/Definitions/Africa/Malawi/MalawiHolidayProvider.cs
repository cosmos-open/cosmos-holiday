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
    using Definitions.Africa.Malawi.Commemoration;
    using Definitions.Africa.Malawi.Public;
    using Definitions.Africa.Malawi.Religion;

    /// <summary>
    /// Malawi holiday provider
    /// </summary>
    public class MalawiHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Malawi;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Malawi;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = MwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> MwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = MwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> MwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new JohnChilembweDay(),//1-15
            new MartyrsDay(),//3-3
            new GoodFriday(),
            new EasterSunday(),
            new EasterMonday(),
            new LabourDay(), //5-1
            new KamuzuDay(),//5-14
            new IndependenceDay(), //7-6
            new MothersDay(),//10-15
            new EndOfRamadan()
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "http://www.malawilii.org/mw/consolidatedlegislation/1805/public_holidays_act_pdf_49780.pdf"
            };
        }
    }
}