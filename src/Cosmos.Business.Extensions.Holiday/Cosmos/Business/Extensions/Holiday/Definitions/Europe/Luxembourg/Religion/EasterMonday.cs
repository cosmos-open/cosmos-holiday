using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Luxembourg.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override string Name { get; } = "Ouschterméindeg";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lu_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}