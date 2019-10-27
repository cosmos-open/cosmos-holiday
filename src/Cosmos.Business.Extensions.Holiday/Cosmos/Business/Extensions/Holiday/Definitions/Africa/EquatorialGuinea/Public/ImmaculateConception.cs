using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.EquatorialGuinea.Public
{
    /// <summary>
    /// Immaculate Conception<br />
    /// es: La inmaculada concepción
    /// </summary>
    public class ImmaculateConception : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override string Name { get; } = "La inmaculada concepción";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 12;

        /// <inheritdoc />
        public override int Day { get; } = 8;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gq_immaculate_conception";
    }
}