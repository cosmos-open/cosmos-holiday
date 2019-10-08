using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoKinshasa.Commemoration
{
    /// <summary>
    /// Day of the Martyrs<br />
    /// fr: Martyrs de l'Indépendance
    /// </summary>
    public class MartyrsDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoKinshasa;

        /// <inheritdoc />
        public override string Name { get; } = "Martyrs de l'Indépendance";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get;  } = 1;

        /// <inheritdoc />
        public override int Day { get;  } = 4;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cd_martyr";
    }
}