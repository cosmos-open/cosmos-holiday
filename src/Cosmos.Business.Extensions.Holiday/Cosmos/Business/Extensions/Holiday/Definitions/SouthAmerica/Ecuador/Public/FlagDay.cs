using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Ecuador.Public
{
    /// <summary>
    /// Flag Day<br />
    /// es: Dia de La Bandera
    /// </summary>
    public class FlagDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de La Bandera";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 31;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ec_flag_day";
    }
}