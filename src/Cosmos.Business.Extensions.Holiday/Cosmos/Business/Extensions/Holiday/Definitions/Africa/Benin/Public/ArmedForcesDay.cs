using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Benin.Public
{
    /// <summary>
    /// Armed Force's Day
    /// </summary>
    public class ArmedForcesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Benin;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Benin;

        /// <inheritdoc />
        public override string Name { get; } = "Armed Force's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bj_armed_forces";
    }
}