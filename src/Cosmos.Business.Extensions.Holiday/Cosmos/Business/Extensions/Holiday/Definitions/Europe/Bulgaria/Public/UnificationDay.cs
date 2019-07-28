using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Bulgaria.Public
{
    /// <summary>
    /// Unification Day
    /// </summary>
    public class UnificationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override string Name { get; } = "Ден на Съединението";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bg_unification";
    }
}