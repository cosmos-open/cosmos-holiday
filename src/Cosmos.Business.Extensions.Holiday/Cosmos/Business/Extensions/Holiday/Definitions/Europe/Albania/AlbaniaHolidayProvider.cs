using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.Albania.Public;
    using Definitions.Europe.Albania.Religion;
    using Definitions.Europe.Albania.Tradition;

    /// <summary>
    /// Albania holiday provider
    /// </summary>
    public class AlbaniaHolidayProvider : BaseDefinitionRegister
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Albania;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions()
        {
            return new[] {CountryHelper.GetRegionCode(Country, BelongsToCountry)};
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AxFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AxFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new SummerDay(), //3-14
            new Nowruz(), //3-22
            new MayDay(), //5-1
            new MotherTeresaDay(), //10-19
            new IndependenceDay(), //11-28
            new LiberationDay(), //11-29
            new YouthDay(), //12-8
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AxVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AxVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new EasterSunday(),
            new EasterMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Albania"
            };
        }
    }
}