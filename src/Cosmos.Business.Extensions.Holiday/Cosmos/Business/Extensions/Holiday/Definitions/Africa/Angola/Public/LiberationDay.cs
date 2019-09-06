using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Angola.Public
{
    /// <summary>
    /// Liberation Day
    /// </summary>
    public class LiberationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Angola;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Angola;

        /// <inheritdoc />
        public override string Name { get; } = "Dia do Início da Luta Armada de Libertação Nacional";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ao_liberation";
    }
}