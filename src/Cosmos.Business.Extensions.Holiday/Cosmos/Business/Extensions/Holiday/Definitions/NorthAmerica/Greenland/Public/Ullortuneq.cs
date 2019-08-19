using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Greenland.Public
{
    /// <summary>
    /// Ullortuneq
    /// </summary>
    public class Ullortuneq : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Greenland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Greenland;

        /// <inheritdoc />
        public override string Name { get; } = "Ullortuneq";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gl_ullortuneq";
    }
}