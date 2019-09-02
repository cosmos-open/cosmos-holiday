using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Colombia.Religion
{
    /// <summary>
    /// Maundy Thursday
    /// </summary>
    public class MaundyThursday: CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Colombia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Colombia;
        
        /// <inheritdoc />
        public override string Name { get; } = "Jueves Santo";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_co_maundy_thursday";
    }
}