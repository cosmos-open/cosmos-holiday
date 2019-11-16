using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Religion
{
    /// <summary>
    /// Christmas Day<br />
    /// nl: Kerstmis
    /// </summary>
    public class ChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Kerstmis";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set;} = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_christmas";
    }
}