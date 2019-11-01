using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Public
{
    /// <summary>
    /// Statehood Day<br />
    /// hr: Dan državnosti
    /// sr: Дан државности
    /// </summary>
    public class StatehoodDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Dan državnosti";

        /// <inheritdoc />
        public override int Month { get; } = 7;

        /// <inheritdoc />
        public override int Day { get; } = 13;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_statehood";
    }
}