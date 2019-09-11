using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Oceania.AmericanSamoa.Commemoration;
    using Definitions.Oceania.AmericanSamoa.Public;
    using Definitions.Oceania.AmericanSamoa.Religion;

    /// <summary>
    /// American Samoa Holiday Provider
    /// </summary>
    public class AmericanSamoaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.AmericanSamoa;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions()
        {
            return new[] {CountryHelper.GetRegionCode(Country, BelongsToCountry)};
        }

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AsFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new ManuaCessionDay(),
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new MlkDay(), //1月的第三个周一
            new PresidentsDay(), //2月的第三个周一
            new AmericanSamoaFlagDay(),//4-17
            new MothersDay(), //母亲节，5月第二个周日
            new MemorialDay(), //5月最后一个周一
            new FathersDay(), //父亲节，6月第三个周日
            new IndependenceDay(), //7-4
            new LaborDay(), //9月第一个周一
            new WhiteSunday(),//10-2nd-sunday
            new VeteransDay(), //11-11
            new ThanksgivingDay(), //11月第四个周四
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://www.anz.com/americansamoa/en/about-us/anz-american-samoa/country-information/public-holidays/"
            };
        }
    }
}