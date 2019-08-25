using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Brazil.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brazil;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brazil;

        /// <inheritdoc />
        public override string Name { get; } = "Domingo de Pascoa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_br_easter_day";
    }
}