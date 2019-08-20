using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominican.Public
{
    /// <summary>
    /// Restoration Day
    /// </summary>
    public class RestorationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominican;

        /// <inheritdoc />
        public override string Name { get; } = "Restoration Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_do_restoration";
    }
}