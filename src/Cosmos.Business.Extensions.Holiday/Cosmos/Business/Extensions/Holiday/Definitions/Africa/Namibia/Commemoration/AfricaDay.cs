using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Namibia.Commemoration
{
    /// <summary>
    /// Africa Day
    /// </summary>
    public class AfricaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Namibia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Namibia;

        /// <inheritdoc />
        public override string Name { get; } = "Africa Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_na_africa_day";
    }
}