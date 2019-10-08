using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoKinshasa.Public
{
    /// <summary>
    /// Liberation Day<br />
    /// fr: Journée de la Révolution et des Forces Armées
    /// </summary>
    public class LiberationDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override string Name { get; } = "Journée de la Révolution et des Forces Armées";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        public override int Day { get; } = 17;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cd_liberation";
    }
}