using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Morocco.Public
{
    /// <summary>
    /// Zikra Oued Ed-Dahab 忠诚日
    /// <br />Oued Eddahab
    /// </summary>
    public class ZikraOuedEdDahab : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Morocco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Morocco;

        /// <inheritdoc />
        public override string Name { get; } = "Oued Ed-Dahab Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ma_zikra_oued_ed_dahab";
    }
}