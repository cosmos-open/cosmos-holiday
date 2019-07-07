using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovakia.Commemoration
{
    /// <summary>
    /// Slovak National Uprising anniversary
    /// </summary>
    public class UprisingAnniversary : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override string Name { get; } = "Výročie Slovenského národného povstania";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 29;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sk_uprising_ann";
    }
}