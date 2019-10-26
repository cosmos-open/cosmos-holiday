using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominica.Religion
{
    /// <summary>
    /// Boxing Day<br />
    /// fr: Lendemain de Noël
    /// </summary>
    public class BoxingDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominica;

        /// <inheritdoc />
        public override string Name { get; } = "Boxing day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dm_boxing_day";
    }
}