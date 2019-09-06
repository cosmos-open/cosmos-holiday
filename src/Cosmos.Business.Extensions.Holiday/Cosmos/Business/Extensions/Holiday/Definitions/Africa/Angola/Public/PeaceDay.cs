using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Angola.Public
{
    /// <summary>
    /// Peace Day
    /// </summary>
    public class PeaceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Angola;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Angola;

        /// <inheritdoc />
        public override string Name { get; } = "Dia da Paz";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ao_peace";
    }
}