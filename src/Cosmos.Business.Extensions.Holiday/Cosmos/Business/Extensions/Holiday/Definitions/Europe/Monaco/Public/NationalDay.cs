using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Monaco.Public
{
    /// <summary>
    /// National Day
    /// </summary>
    public class NationalDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Monaco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Monaco;

        /// <inheritdoc />
        public override string Name { get; } = "La Fête du Prince";

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 19;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mc_national";
    }
}