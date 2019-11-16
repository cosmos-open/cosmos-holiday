using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Religion
{
    /// <summary>
    /// Boxing Day<br />
    /// nl: Tweede kerstdag
    /// </summary>
    public class BoxingDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Tweede kerstdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set;} = 12;

        /// <inheritdoc />
        public override int Day { get; set;} = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_boxing";
    }
}