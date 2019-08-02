using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Lithuania.Public
{
    /// <summary>
    /// The Day of Restoration of the State of Lithuania
    /// </summary>
    public class StateDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Lithuania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Lithuania;

        /// <inheritdoc />
        public override string Name { get; } = "Lietuvos valstybės atkūrimo diena";

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lt_state";
    }
}