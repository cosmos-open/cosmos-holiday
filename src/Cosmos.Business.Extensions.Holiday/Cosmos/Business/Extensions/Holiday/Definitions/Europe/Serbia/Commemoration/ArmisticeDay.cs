using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Serbia.Commemoration
{
    /// <summary>
    /// Armistice Day
    /// </summary>
    public class ArmisticeDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Serbia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <inheritdoc />
        public override string Name { get; } = "Dan primirja";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rs_armistice";
    }
}