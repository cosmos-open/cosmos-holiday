using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Azerbaijan.Public
{
    /// <summary>
    /// National Revival Day
    /// </summary>
    public class NationalRevivalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override string Name { get; } = "Milli Dirçəliş günü";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_az_national_revival";
    }
}