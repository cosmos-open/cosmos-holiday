using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Portugal.Religion
{
    /// <summary>
    /// Easter Day
    /// </summary>
    public class EasterDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Portugal;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <inheritdoc />
        public override string Name { get; } = "Domingo de Páscoa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pt_easter_day";
    }
}