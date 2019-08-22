using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Panama.Commemoration
{
    /// <summary>
    /// Martyrs' Day
    /// </summary>
    public class MartyrsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Panama;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Panama;

        /// <inheritdoc />
        public override string Name { get; } = "Martyrs' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pa_martyr";
    }
}