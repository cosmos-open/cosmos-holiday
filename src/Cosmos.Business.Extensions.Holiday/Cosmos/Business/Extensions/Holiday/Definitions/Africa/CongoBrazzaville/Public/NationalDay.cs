using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoBrazzaville.Public
{
    /// <summary>
    /// National Day<br />
    /// fr: Journée nationale de la République
    /// </summary>
    public class NationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override string Name { get; } = "Journée nationale de la République";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cg_nation";
    }
}