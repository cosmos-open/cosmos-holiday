using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.CostaRica.Public
{
    /// <summary>
    /// Guanacaste Day
    /// </summary>
    public class GuanacasteDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override string Name { get; } = "Guanacaste Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cr_guanacaste";
    }
}