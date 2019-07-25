using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Venezuela.School
{
    /// <summary>
    /// Teacher's Day
    /// </summary>
    public class TeachersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override string Name { get; } = "Día del Maestro";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.School;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ve_teachers";
    }
}