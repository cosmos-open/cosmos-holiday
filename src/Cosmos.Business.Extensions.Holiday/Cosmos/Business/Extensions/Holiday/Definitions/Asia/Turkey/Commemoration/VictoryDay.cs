using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Turkey.Commemoration
{
    /// <summary>
    /// Victory Day
    /// </summary>
    public class VictoryDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Turkey;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Turkey;

        /// <inheritdoc />
        public override string Name { get; } = "Zafer Bayramı";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tr_victory";
    }
}