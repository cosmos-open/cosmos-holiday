using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Niger.Public
{
    /// <summary>
    /// Nigerien Independence Day
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Niger;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Niger;

        /// <inheritdoc />
        public override string Name { get; } = "Nigerien Independence Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ne_independence";
    }
}