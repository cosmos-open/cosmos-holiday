using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Tunisia.Public
{
    /// <summary>
    /// Women's Day
    /// </summary>
    public class WomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tunisia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tunisia;

        /// <inheritdoc />
        public override string Name { get; } = "Women's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 13;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tn_women";
    }
}