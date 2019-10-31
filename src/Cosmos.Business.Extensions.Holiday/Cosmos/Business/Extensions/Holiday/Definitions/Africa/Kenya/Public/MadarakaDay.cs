using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Kenya.Public
{
    /// <summary>
    /// Madaraka Day<br />
    /// sw: Siku ya Madaraka
    /// </summary>
    public class MadarakaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kenya;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kenya;

        /// <inheritdoc />
        public override string Name { get; } = "Siku ya Madaraka";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ke_madaraka";
    }
}