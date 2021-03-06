using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Commemoration
{
    /// <summary>
    /// Homeland protector Day - Mai 7st
    /// </summary>
    public class HomelandProtectorDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "День Защитника Отечества";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_homeland_protector";
    }
}