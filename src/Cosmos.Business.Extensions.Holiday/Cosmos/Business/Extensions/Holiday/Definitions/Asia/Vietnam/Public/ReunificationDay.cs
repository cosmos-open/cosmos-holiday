using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Vietnam.Public
{
    /// <summary>
    /// Reunification Day
    /// </summary>
    public class ReunificationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Vietnam;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Vietnam;

        /// <inheritdoc />
        public override string Name { get; } = "Ngày Giải phóng miền Nam, thống nhất đất nước";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nv_reunification";
    }
}