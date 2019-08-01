using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Religion
{
    /// <summary>
    /// Immaculate Conception
    /// </summary>
    public class ImmaculateConception : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Inmaculada Concepción";

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pe_immaculate_conception";
    }
}