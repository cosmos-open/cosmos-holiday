using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Guyana.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday: CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guyana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guyana;
        
        /// <inheritdoc />
        public override string Name { get; } = "Easter Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gy_easter_monday";
    }
}