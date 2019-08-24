using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Argentina.Public
{
    /// <summary>
    /// Immaculate Conception Day
    /// </summary>
    public class ImmaculateConceptionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Argentina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Argentina;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Inmaculada Concepción de María";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ar_immaculate_conception_day";
    }
}