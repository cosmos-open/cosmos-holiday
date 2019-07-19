using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Lesotho.Commemoration
{
    /// <summary>
    /// King Letsie III's Birthday
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class KingLetsieIIIsBirthday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override string Name { get; } = "King Letsie III's Birthday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ls_king_letsie_iii_birthday";
    }
}