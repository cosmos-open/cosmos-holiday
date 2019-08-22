using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Oceania.NewZealand.Public;
    using Definitions.Oceania.NewZealand.Religion;

    /// <summary>
    /// NewZealand Holiday Provider
    /// </summary>
    public class NewZealandHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.NewZealand;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.NewZealand;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = NzFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> NzFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new WaitangiDay2015B(), //2-6
            new AnzacDay2014B(), //4-25
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = NzVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> NzVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NewYearsDay2(), //1-2
            new WaitangiDay(), //2-6
            new AnzacDay(), //4-25
            new QueenBirthday(), //6月第一个周一
            new LabourDay(), //10月第四个周一
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
            new EasterMonday(),
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_New_Zealand"
            };
        }
    }
}