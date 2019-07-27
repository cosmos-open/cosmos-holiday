using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Indonesia.Public
{
    /// <summary>
    /// Pancasila Day
    /// </summary>
    public class PancasilaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Indonesia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Indonesia;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Lahir Pancasila";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_id_pancasila";
    }
}