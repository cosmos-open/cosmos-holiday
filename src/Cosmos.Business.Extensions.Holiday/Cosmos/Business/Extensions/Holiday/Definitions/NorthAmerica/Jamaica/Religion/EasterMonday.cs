using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Jamaica.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override string Name { get; } = "Easter Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jm_easter_monday";
    }
}