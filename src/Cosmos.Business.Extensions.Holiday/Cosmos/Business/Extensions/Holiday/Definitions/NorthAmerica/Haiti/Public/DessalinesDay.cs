using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Haiti.Public
{
    /// <summary>
    /// Dessalines Day
    /// </summary>
    public class DessalinesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Haiti;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Haiti;

        /// <inheritdoc />
        public override string Name { get; } = "Anniversaire de la mort de Dessalines";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ht_dessalines";
    }
}