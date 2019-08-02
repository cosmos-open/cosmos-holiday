using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Luxembourg.Commemoration
{
    /// <summary>
    /// Sovereign's birthday
    /// </summary>
    public class SovereignsBirthday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override string Name { get; } = "Groussherzogsgebuertsdag";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lu_sovereign_birthday";
    }
}