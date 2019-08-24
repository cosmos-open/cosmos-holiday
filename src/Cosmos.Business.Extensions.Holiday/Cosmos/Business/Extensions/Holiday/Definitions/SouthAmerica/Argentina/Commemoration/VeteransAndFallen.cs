using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Argentina.Commemoration
{
    /// <summary>
    /// Day of the Veterans and Fallen of the Malvinas War
    /// </summary>
    public class VeteransAndFallen : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Argentina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Argentina;

        /// <inheritdoc />
        public override string Name { get; } = "Día del Veterano y de los Caídos en la Guerra de Malvinas";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ar_malvinas_war";
    }
}