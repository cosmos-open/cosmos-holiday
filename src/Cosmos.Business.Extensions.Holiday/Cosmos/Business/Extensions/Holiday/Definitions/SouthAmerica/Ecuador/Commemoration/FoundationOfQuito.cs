using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;
using Cosmos.I18N.Countries.SouthAmerica;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Ecuador.Commemoration
{
    /// <summary>
    /// Foundation of Quito<br />
    /// es: Aniversario de la fundación de Quito
    /// </summary>
    public class FoundationOfQuito : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override string Name { get; } = "El Natalicio de Simón Bolívar";

        /// <inheritdoc />
        public override string RegionCode { get; } = "EC-P";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ec_quito";
    }
}