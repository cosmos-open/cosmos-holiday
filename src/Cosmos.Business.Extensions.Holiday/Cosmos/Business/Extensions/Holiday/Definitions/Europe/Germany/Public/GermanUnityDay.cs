using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Public
{
    /// <summary>
    /// German Unity Day
    /// </summary>
    public class GermanUnityDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override string Name { get; } = "Tag der Deutschen Einheit";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_unity_day";
    }
}