using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominican.Commemoration
{
    /// <summary>
    /// Duarte's Birthday
    /// </summary>
    public class DuartesBirthday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominican;

        /// <inheritdoc />
        public override string Name { get; } = "Duarte's Birthday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_do_duarte_birthday";
    }
}