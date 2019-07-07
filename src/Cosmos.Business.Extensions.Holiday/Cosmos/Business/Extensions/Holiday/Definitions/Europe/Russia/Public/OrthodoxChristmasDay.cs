using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Russia.Public
{
    /// <summary>
    /// Orthodox Christmas Day
    /// </summary>
    public class OrthodoxChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Russia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Russia;

        /// <inheritdoc />
        public override string Name { get; } = "Рождество Христово";

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ru_orthodox_christmas_day";
    }
}