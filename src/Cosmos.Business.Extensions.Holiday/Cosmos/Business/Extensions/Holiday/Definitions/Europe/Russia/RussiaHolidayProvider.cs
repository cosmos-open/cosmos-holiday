using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Russia.Commemoration;
    using Definitions.Europe.Russia.Public;

    /// <summary>
    /// Russia holiday provider
    /// </summary>
    public class RussiaHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Russia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Russia;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = RuFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> RuFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NewYearsHoliday(), //1-2 ~ 1-6
            new OrthodoxChristmasDay(), //1-7
            new DefenderOfTheFatherlandDay(), //2-23
            new InternationalWomensDay(), //3-8
            new LabourDay(), //5-1
            new VictoryDay(), //5-9
            new RussiaDay(), //6-12
            new UnityDay(), //11-4
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = RuVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> RuVariableHolidayFuncs = new List<IVariableHolidayFunc>();

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Russia"
            };
        }
    }
}