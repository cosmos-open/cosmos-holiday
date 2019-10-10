using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Commemoration
{
    /// <summary>
    /// Birthday of Muhammad<br />
    /// ms: Maulidur Rasul
    /// </summary>
    public class BirthdayOfMuhammad: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Maulidur Rasul";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.RabiAlAwwal;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_birthday_muhammad";
    }
}