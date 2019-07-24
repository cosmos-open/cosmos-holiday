using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Niger.Public
{
    /// <summary>
    /// Nigerien Republic Day
    /// </summary>
    public class RepublicDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Niger;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Niger;

        /// <inheritdoc />
        public override string Name { get; } = "Nigerien Republic Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 18;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ne_republic";
    }
}