using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.ElSalvador.Public
{
    /// <summary>
    /// Independence Day
    /// </summary>
    public class IndependenceDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override string Name { get; } ="Día de la Independencia";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sv_independence_day";
    }
}