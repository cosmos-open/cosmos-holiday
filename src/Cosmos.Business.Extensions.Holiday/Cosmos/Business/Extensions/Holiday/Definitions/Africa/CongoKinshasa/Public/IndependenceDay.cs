using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoKinshasa.Public
{
    /// <summary>
    /// Independence Day<br />
    /// fr: Anniversaire de Indépendance
    /// </summary>
    public class IndependenceDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override string Name { get; } = "Anniversaire de Indépendance";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        public override int Day { get; } = 30;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cd_independence";
    }
}