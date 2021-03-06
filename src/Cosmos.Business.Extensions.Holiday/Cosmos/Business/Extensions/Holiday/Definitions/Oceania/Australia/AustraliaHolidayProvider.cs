using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.Oceania;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Oceania.Australia.Public;
    using Definitions.Oceania.Australia.Religion;

    /// <summary>
    /// Australia Holiday Provider
    /// </summary>
    public class AustraliaHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = AustraliaRegions.GetMainlandRegionCodes();

        private static IEnumerable<string> OverseasRegionCache { get; }

        static AustraliaHolidayProvider()
        {
            OverseasRegionCache = AustraliaRegions.GetOverseasRegionCodes()
                .Select(code => CountryHelper.FixRegionCode(CountryCode.AU, code));
        }

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Australia;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <inheritdoc />
        public override bool DoesIncludeRegion(string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;

            regionCode = CountryHelper.FixRegionCode(Country.Australia, regionCode);

            return OverseasRegionCache.Contains(regionCode) || base.DoesIncludeRegion(regionCode);
        }

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = AuFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> AuFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new AnzacDayNswQldTasVic(), //4-15
        };

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = AuVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> AuVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new AustraliaDay(), //1-26
            new CanberraDay(), //3月的第二个周一
            new LabourDayWa(), //3-1
            new LabourDayTasVic(), //3月第二个周一
            new EightHoursDay(),//3-2nd-monday
            new AnzacDayActNtSaWa(), //4-25
            new LabourDayNtQld(), //5-1
            new WesternAustraliaDay(), //6月第一个周一
            new QueenBirthdayActNswNtSaTasVic(), //6月第二个周一
            new QueenBirthdayQld(), //6月的第二个周一
            new PicnicDay(), //8月第一个周一
            new QueenBirthdayWa(), //9-30 前的周一
            new LabourDayActNswSa(), //10-1
            new FamilyAndCommunityDay(), //10-1 or 11-1
            new MelbourneCup(), //11月第一个周二
            new ChristmasDay(), //12-25
            new BoxingDay(), //12-26
            new BoxingDaySa(), //12-26
            new EasterMonday(),
            new GoodFriday(),
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_Australia",
                "http://www.australia.gov.au/about-australia/special-dates-and-events/public-holidays",
                "http://www.cmd.act.gov.au/communication/holidays", //ACT
                "http://www.industrialrelations.nsw.gov.au/oirwww/NSW_public_holidays/NSW_Public_Holidays.page?", //NSW
                "http://www.ocpe.nt.gov.au/working_in_the_ntps/legislation/public_holidays",//NT
                "https://www.qld.gov.au/recreation/travel/holidays/public",//QLD
                "http://www.safework.sa.gov.au/show_page.jsp?id=2483",//SA
                "http://worksafe.tas.gov.au/laws/public_holidays",//TAS
                "http://www.business.vic.gov.au/victorian-public-holidays-and-daylight-saving/victorian-public-holidays",//VIC
                "https://www.commerce.wa.gov.au/labour-relations/public-holidays-western-australia",//WA
            };
        }
    }
}