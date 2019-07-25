using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Albania.Public
{
    /// <summary>
    /// Liberation Day
    /// </summary>
    public class LiberationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Albania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Albania;

        /// <inheritdoc />
        public override string Name { get; } = "Dita e Çlirimit";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 29;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_al_liberation";
    }
}