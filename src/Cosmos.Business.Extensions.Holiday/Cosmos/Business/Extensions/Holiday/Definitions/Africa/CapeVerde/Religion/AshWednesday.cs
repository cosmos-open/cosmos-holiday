using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CapeVerde.Religion
{
    /// <summary>
    /// Ash Wednesday<br />
    /// pt: Quarta-feira de Cinzas
    /// </summary>
    public class AshWednesday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override string Name { get; } = "Quarta-feira de Cinzas";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -46;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cv_ash_wednesday";
    }
}