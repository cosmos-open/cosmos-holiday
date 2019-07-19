using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.ElSalvador.Public
{
    /// <summary>
    /// Children's Day
    /// </summary>
    public class ChildrensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override string Name { get; } = "Día del niño";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sv_childrens_day";
    }
}