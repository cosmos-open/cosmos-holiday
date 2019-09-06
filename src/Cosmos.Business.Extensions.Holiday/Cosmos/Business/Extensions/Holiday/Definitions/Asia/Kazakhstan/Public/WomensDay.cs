using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Public
{
    /// <summary>
    /// Woman's Day
    /// </summary>
    public class WomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "Международный женский день";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_women";
    }
}