using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Commemoration
{
    /// <summary>
    /// Constitution Day
    /// </summary>
    public class ConstitutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override string Name { get; } = "Jura de la Constitución";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 18;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_constitution_day";
    }
}