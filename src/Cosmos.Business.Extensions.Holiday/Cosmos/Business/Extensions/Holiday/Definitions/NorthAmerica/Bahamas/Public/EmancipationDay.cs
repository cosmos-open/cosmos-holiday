using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bahamas.Public
{
    /// <summary>
    /// Emancipation Day
    /// </summary>
    public class EmancipationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override string Name { get; } = "Emancipation Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bs_emancipation";
    }
}