using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belgium.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belgium;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belgium;

        /// <summary>
        /// Easter Monday
        /// </summary>
        public override string Name { get; } = "Paasmaandag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_be_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}