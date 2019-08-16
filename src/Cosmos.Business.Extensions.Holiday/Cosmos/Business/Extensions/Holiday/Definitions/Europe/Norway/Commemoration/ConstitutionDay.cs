using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Norway.Commemoration
{
    /// <summary>
    /// Constitution Day
    /// </summary>
    public class ConstitutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Norway;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Norway;

        /// <inheritdoc />
        public override string Name { get; } = "Syttende mai";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_no_constitution";
    }
}