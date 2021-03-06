using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Switzerland.Commemoration;
    using Definitions.Europe.Switzerland.Public;
    using Definitions.Europe.Switzerland.Religion;
    using Definitions.Europe.Switzerland.Tradition;

    /// <summary>
    /// Switzerland holiday provider
    /// </summary>
    public class SwitzerlandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Switzerland;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = ChFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> ChFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new SecondJanuary(), //1-2
            new Epiphany(), //1-6
            new SaintJosephsDay(), //3-19
            new LabourDay(), //5-1
            new SwissNationalDay(), //8-1
            new AssumptionOfTheVirginMary(), //8-15
            new ImmaculateConception(), //12-8
            new ChristmasDay(), //12-25
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = ChVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> ChVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new MothersDay(), //5-2nd-sunday
            new FathersDay(), //6-1st-sunday
            new JeûneFédéral(), //9-3rd-month
            new AllSaintsDay(), //11-1st-monday
            new AscensionDay(),
            new CorpusChristi(),
            new EasterMonday(),
            new GoodFriday(),
            new WhitMonday(),
            new FederalDay(),//9-3rd-sunday
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://de.wikipedia.org/wiki/Feiertage_in_der_Schweiz"
            };
        }
    }
}