using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Guatemala.Religion
{
    /// <summary>
    /// Maundy Thursday
    /// </summary>
    public class MaundyThursday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override string Name { get; } = "Maundy Thursday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gt_maundy_thursday";
    }
}