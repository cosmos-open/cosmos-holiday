using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Vatican.Religion
{
    /// <summary>
    /// Anniversary of the foundation of Vatican City
    /// </summary>
    public class AnniversaryOfTheFoundation : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Vatican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Vatican;

        /// <inheritdoc />
        public override string Name { get; } = "Anniversario della istituzione dello Stato della Città del Vaticano";

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_va_anniversary_of_the_foundation";
    }
}