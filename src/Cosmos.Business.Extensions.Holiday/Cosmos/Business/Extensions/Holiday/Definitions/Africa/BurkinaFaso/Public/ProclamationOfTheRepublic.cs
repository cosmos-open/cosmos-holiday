using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.BurkinaFaso.Public
{
    /// <summary>
    /// Proclamation of the Republic<br />
    /// fr: Fête nationale
    /// </summary>
    public class ProclamationOfTheRepublic : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override string Name { get; } = "Fête nationale";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bf_proclamation_republic";
    }
}