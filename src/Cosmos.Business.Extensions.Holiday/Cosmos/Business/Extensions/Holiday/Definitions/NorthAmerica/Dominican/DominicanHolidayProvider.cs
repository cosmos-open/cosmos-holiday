using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.NorthAmerica.Dominican.Public;
    using Definitions.NorthAmerica.Dominican.Religion;
    using Definitions.NorthAmerica.Dominican.Commemoration;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class DominicanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = DominicanRegions.GetAllRegonCodes();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Dominican;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Dominican;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = DoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> DoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new DayOfKings(), //1-6
            new OurLadyOfAltagracia(), //1-21
            new DuartesBirthday(), //1-26
            new IndependenceDay(), //2-27
            new LabourDay(), //5-1
            new MothersDay(), //5-28
            new RestorationDay(), //8-16
            new OurLadyOfMercy(), //9-24
            new ConstitutionDay(), //11-6
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = DoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> DoVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GoodFriday(),
            new CorpusChristi(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Dominican",
            };
        }
    }
}