using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.CostaRica.Commemoration
{
    /// <summary>
    /// Virgin of Los Angeles Day
    /// </summary>
    public class VirginOfLosAngelesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override string Name { get; } = "Virgin of Los Angeles Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cr_virgin_of_los_angeles";
    }
}