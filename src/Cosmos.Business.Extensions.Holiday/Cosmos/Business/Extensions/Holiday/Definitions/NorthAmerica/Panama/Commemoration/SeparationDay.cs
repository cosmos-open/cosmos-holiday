using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Panama.Commemoration
{
    /// <summary>
    /// Separation Day
    /// </summary>
    public class SeparationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Panama;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Panama;

        /// <inheritdoc />
        public override string Name { get; } = "Separation Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pa_separation";
    }
}