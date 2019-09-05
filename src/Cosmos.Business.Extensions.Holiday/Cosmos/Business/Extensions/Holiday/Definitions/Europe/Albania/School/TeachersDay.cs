using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Albania.School
{
    /// <summary>
    /// Teacher's Day
    /// </summary>
    public class TeachersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Albania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Albania;

        /// <inheritdoc />
        public override string Name { get; } = "Dita e Mësuesit";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.School;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_al_teacher";
    }
}