using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Asia.Taiwan.Public;
    using Definitions.Asia.Taiwan.Tradition;

    /// <summary>
    /// China Taiwan holiday provider
    /// </summary>
    public class TaiwanHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Taiwan;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Include region
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions()
        {
            return new[] {Core.Helpers.CountryHelper.GetRegionCode(Country, BelongsToCountry)};
        }

        /// <summary>
        /// Gets all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnTwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnTwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NationalDay(), //10-1
            new MinGuoNationalDay(), //10-10
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnTwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnTwVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new ChineseNewYearsEve(), //农历（上一年）12-30
            new ChineseNewYear(), //农历1-1
            new LanternFestival(), //农历1-15
            new TombSweepingDay(), //4-5
            new DragonBoatFestival(), //农历5-5
            new MidAutumnFestival(), //农历8-15
            new DoubleNinthFestival(), //农历9-9
            new LabaFestival(), //农历12-8
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_China",
            };
        }
    }
}