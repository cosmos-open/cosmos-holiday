using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    public class HongKongReturnDay : BaseFixedHolidayFunc
    {
        public override Country Country { get; set; } = Country.China;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Hongkong's return day
        /// </summary>
        public override string Name { get; } = "香港回归纪念日";

        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        public override int Month { get; set; } = 7;

        public override int Day { get; set; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_hk1997";

        public override int? Since { get; } = 1997;

    }
}