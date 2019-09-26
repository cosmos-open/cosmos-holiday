using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bahrain.Commemoration
{
    /// <summary>
    /// Birthday of Muhammad<br />
    /// ar: 'المولد النبويّ'
    /// </summary>
    public class BirthdayOfMuhammad: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override string Name { get; } = "'المولد النبويّ'";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.RabiAlAwwal;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bh_birthday_muhammad";
    }
}