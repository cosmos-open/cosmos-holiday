using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Somalia.Commemoration
{
    /// <summary>
    /// Birthday of Muhammad<br />
    /// ar: 'المولد النبويّ'
    /// </summary>
    public class BirthdayOfMuhammad: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Somalia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <inheritdoc />
        public override string Name { get; } = "Birthday of Muhammad (Mawlid)";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.RabiAlAwwal;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_so_birthday_muhammad";
    }
}