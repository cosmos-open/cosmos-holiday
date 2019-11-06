using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Uganda.Religion
{
    /// <summary>
    /// Ash Wednesday<br />
    /// pt: Quarta-feira de Cinzas
    /// </summary>
    public class AshWednesday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uganda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uganda;

        /// <inheritdoc />
        public override string Name { get; } = "Ash Wednesday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -46;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ug_ash_wednesday";
    }
}