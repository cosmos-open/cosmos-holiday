using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belgium.Commemoration
{
    /// <summary>
    /// Saint Nicholas
    /// </summary>
    public class SaintNicholas : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belgium;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belgium;

        /// <inheritdoc />
        public override string Name { get; } = "Saint Nicholas";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_be_nicholas";
    }
}