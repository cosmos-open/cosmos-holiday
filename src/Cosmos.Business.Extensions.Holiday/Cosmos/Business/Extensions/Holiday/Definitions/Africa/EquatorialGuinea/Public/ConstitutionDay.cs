using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.EquatorialGuinea.Public
{
    /// <summary>
    /// Constitution Day<bs />
    /// es: Día de la Constitución
    /// </summary>
    public class ConstitutionDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Constitución";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        public override int Day { get; } = 15;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gq_constitution";
    }
}