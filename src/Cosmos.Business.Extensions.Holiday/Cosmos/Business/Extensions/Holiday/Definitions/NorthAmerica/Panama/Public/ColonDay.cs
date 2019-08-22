using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Panama.Public
{
    /// <summary>
    /// Colon Day
    /// </summary>
    public class ColonDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Panama;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Panama;

        /// <inheritdoc />
        public override string Name { get; } = "Colón Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pa_colon";
    }
}