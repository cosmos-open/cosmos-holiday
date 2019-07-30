using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Denmark.Religion
{
    /// <summary>
    /// Štědrý den - Christmas Eve
    /// Valid since 1990, before that it was not a public holiday
    /// </summary>
    public class ChristmasEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Denmark;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Denmark;

        /// <inheritdoc />
        public override string Name { get; } = "Juleaftensdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dk_christmas_eve";
    }
}