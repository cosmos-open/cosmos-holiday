using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    public class NationalDay : BaseFixedHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// National Day
        /// </summary>
        public override string Name { get; } = "国庆节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; set; } = 10;

        public override int Day { get; set; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_china10";

        public override int? Since { get; } = 1949;
    }
}