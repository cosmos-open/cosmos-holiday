using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoKinshasa.Commemoration
{
    /// <summary>
    /// Anniversary of President Laurent Kabila<br />
    /// fr： Journée du Héro National Laurent Désiré Kabila
    /// </summary>
    public class AnniversaryOfPresidentLaurentKabila : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override string Name { get; } = "Journée du Héro National Laurent Désiré Kabila";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 1;

        /// <inheritdoc />
        public override int Day { get; } = 16;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cd_laurent_kabila";
    }
}