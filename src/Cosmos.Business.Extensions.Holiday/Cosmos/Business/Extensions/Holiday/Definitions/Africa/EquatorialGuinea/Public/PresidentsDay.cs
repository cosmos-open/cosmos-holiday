using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.EquatorialGuinea.Public
{
    /// <summary>
    /// President's Day<br />
    /// es: Natalicio de Teodoro Obiang
    /// </summary>
    public class PresidentsDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.EquatorialGuinea;

        /// <inheritdoc />
        public override string Name { get; } = "Natalicio de Teodoro Obiang";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        public override int Day { get; } = 5;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gq_president";
    }
}