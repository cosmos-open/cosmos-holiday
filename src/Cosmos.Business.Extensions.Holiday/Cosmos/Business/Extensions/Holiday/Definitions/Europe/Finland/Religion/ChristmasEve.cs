using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Finland.Religion
{
    /// <summary>
    /// Christmas Eve
    /// </summary>
    public class ChristmasEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Finland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <inheritdoc />
        public override string Name { get; } = "Jouluaatto";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fi_christmas_eve";
    }
}