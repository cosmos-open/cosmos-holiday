using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.SouthKorea.Public
{
    /// <summary>
    /// Children's Day<br />
    /// ko: 어린이날
    /// </summary>
    public class ChildrensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override string Name { get; } = "어린이날";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kr_children";
    }
}