using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    public class ChildrenDay : BaseFixedHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// International  Children's Day
        /// </summary>
        public override string Name { get; } = "国际儿童节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        public override int Month { get; set; } = 6;

        public override int Day { get; set; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_61";
    }
}