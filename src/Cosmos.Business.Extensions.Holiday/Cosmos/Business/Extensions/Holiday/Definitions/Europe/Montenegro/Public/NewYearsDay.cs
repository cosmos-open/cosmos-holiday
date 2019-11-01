using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Public
{
    /// <summary>
    /// New Year's Day<br />
    /// hr: Nova godina
    /// </summary>
    public class NewYearsDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Nova godina";

        /// <inheritdoc />
        public override int Month { get; } = 1;

        /// <inheritdoc />
        public override int Day { get; } = 1;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_new_year";
    }
}