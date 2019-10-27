using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.EquatorialGuinea.Public
{
    /// <summary>
    /// Independence Day<br />
    /// es: Día de la Independencia
    /// </summary>
    public class IndependenceDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Independencia";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 10;

        /// <inheritdoc />
        public override int Day { get; } = 12;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gq_independence";
    }
}