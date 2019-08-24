using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Argentina.Public
{
    /// <summary>
    /// National Sovereignty Day
    /// </summary>
    public class NationalSovereigntyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Argentina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Argentina;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Soberanía Nacional";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ar_national_sovereignty_day";
    }
}