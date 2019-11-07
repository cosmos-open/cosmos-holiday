using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zambia.Public
{
    /// <summary>
    /// National day of Prayers
    /// </summary>
    public class NationalDayOfPrayers2018 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zambia;

        /// <inheritdoc />
        public override string Name { get; } = "National day of Prayers";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 18;

        /// <inheritdoc />
        protected override int? OnlyYear { get; set; } = 2018;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zm_prayer2018";
    }
}