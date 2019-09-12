using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Aruba.Public
{
    /// <summary>
    /// National Anthem and Flag Day / Herdenking Vlag en Volkslied
    /// </summary>
    public class NationalAnthemAndFlagDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Aruba;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Aruba;

        /// <inheritdoc />
        public override string Name { get; } = "Dia di Himno y Bandera";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 3;

        /// <inheritdoc />
        public override int Day { get; } = 8;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = -1;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_aw_national_anthem_and_flag";
    }
}