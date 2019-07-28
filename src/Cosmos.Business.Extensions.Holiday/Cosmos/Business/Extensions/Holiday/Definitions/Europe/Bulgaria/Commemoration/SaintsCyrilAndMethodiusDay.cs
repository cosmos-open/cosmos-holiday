using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Bulgaria.Commemoration
{
    /// <summary>
    /// Saints Cyril and Methodius Day
    /// </summary>
    public class SaintsCyrilAndMethodiusDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override string Name { get; } = "Ден на българската просвета и култура и на славянската писменост";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bg_cyril_and_methodius";
    }
}