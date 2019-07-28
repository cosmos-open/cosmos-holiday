using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Bulgaria.Commemoration
{
    /// <summary>
    /// Saint George's Day 
    /// </summary>
    public class SaintGeorgesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override string Name { get; } = "Гергьовден, ден на храбростта и Българската армия";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bg_george";
    }
}