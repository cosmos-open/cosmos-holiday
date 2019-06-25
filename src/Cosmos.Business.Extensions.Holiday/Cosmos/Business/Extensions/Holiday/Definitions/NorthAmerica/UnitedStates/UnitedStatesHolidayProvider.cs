using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.NorthAmerica;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates
{
    using Public;
    using Religion;

    /// <summary>
    /// United States Holiday Provider
    /// </summary>
    public class UnitedStatesHolidayProvider : BaseDefinitionRegister
    {
        private static IEnumerable<string> RegionCache { get; } = UnitedStatesRegions.GetMainRegionCodes();
        private static IEnumerable<string> OverseasRegionCache { get; }

        static UnitedStatesHolidayProvider()
        {
            OverseasRegionCache = UnitedStatesRegions.GetOverseasRegionCodes()
                .Select(code => CountryHelper.FixRegionCode(CountryCode.US, code));
        }

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.UnitedStates;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        public override bool DoesIncludeRegion(string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;

            regionCode = CountryHelper.FixRegionCode(Country.China, regionCode);

            return OverseasRegionCache.Contains(regionCode) || base.DoesIncludeRegion(regionCode);
        }

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = UsFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> UsFixedHolidayFuncs = new List<IFixedHolidayFunc>();

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = UsVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> UsVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new InaugurationDay(), //1-20 every 4 year
            new MlkDay(), //1月的第三个周一
            new PresidentsDay(), //2月的第三个周一
            new MothersDay(), //母亲节，5月第二个周日
            new MemorialDay(), //5月最后一个周一
            new FathersDay(), //父亲节，6月第三个周日
            new IndependenceDay(), //7-4
            new LaborDay(), //9月第一个周一
            new ColumbusDay(), //10月第二个周一
            new VeteransDay(), //11-11
            new ThanksgivingDay(), //11月第四个周四
            new ChristmasDay(), //12-25
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Federal_holidays_in_the_United_States"
            };
        }
    }
}