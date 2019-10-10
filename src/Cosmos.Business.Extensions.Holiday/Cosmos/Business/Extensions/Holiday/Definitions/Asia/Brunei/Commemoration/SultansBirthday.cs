using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Commemoration
{
    /// <summary>
    /// Sultan's Birthday<br />
    /// ms: Hari Keputeraan KDYMM Sultan Brunei
    /// </summary>
    public class SultansBirthday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Keputeraan KDYMM Sultan Brunei";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_sultan_birthday";
    }
}